using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Data.OleDb;

namespace Train_Server
{
    public class Server
    {
        public class TicketAndSoOn
        {
            Ticket ticket;
            User user;
            int leftNum;

            public TicketAndSoOn()
            {
                ticket = null;
                user = null;
                leftNum = 0;
            }
            public TicketAndSoOn(Ticket t, User u, int l)
            {
                ticket = t;
                user = u;
                leftNum = l;
            }
        }

        private string hostName = Dns.GetHostName();
        private IPAddress selfIP;
        private Thread th;
        private TcpListener tcpl;
        public bool listenerRun = true;
        //listenerRun为true，表示可以接受连接请求，false则为结束程序
        public string messageBox;

        public User[] users;
        public Linear<Train> trains;
        public Linear<TicketAndSoOn> tickets;

        OleDbConnection conn;

        public Server()
        {
            string address = "Provider=microsoft.ace.oledb.12.0;Data Source=C:\\Users\\john\\Desktop\\Database1.accdb;";
            conn = new OleDbConnection(address);

            try
            {
                IPHostEntry IpEntry = Dns.GetHostEntry(hostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        selfIP = IpEntry.AddressList[i];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("获取本机IP出错:" + ex.Message);
            }

            th = new Thread(new ThreadStart(Listen));  //新建一个用于监听的线程
            th.Start();  //打开新线程
        }

        public void Stop()
        {
            tcpl.Stop();
            th.Abort();  //终止线程
        }

        private void Listen()
        {
            try
            {
                IPAddress ipAddress = selfIP;

                try
                {
                    tcpl = new TcpListener(ipAddress, 5656);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                tcpl.Start();
                Console.WriteLine("started listening..");

                while (listenerRun)  //开始监听
                {
                    Socket s = tcpl.AcceptSocket();
                    string remotetemp = s.RemoteEndPoint.ToString();
                    Byte[] stream = new Byte[800];
                    int ii = s.Receive(stream);  //接受连接请求的字节流
                    messageBox = System.Text.Encoding.UTF8.GetString(stream);
                    //Console.WriteLine(System.Text.Encoding.UTF8.GetString(stream));
                    string[] messageTemp = messageBox.Split(' ');  //发送格式为：ip+account+cmd+内容
                    string tIP = messageTemp[0];
                    string ac = messageTemp[1];
                    string cmd = messageTemp[2].Trim(("\0".ToCharArray()));
                    if (cmd == "login")  //cmd为login，内容为password
                    {
                        string pw = messageTemp[3].Trim(("\0".ToCharArray()));
                        int k = 0;
                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i].account == ac)
                            {
                                if (users[i].passWord == pw)
                                {
                                    string mm = "allow" + " " + users[i].name + " " + users[i].phoneNumber + " " + users[i].ticketnum + " ";
                                    Send(tIP, mm);
                                }
                                else
                                    Send(tIP, "refuse");
                                break;
                            }
                            k++;
                        }
                        if (k == users.Length)
                            Send(tIP, "notlegal");
                    }
                    else if (cmd == "changePW")
                    {
                        for (int i = 0; i < users.Length; i++)
                        {
                            if (ac == users[i].account)
                            {
                                users[i].passWord = messageTemp[3].Trim(("\0".ToCharArray()));
                            }
                        }

                        conn.Open();
                        string str1 = "select count(*) From Users";
                        OleDbCommand cmd1 = new OleDbCommand(str1, conn);
                        int n1 = (int)cmd1.ExecuteScalar();
                        int num = 0;

                        for (int i = 0; i < n1; i++)
                        {
                            int x = i + 1;
                            string strCom = "Select * from Users where MyID=" + x;
                            OleDbCommand myCommand = new OleDbCommand(strCom, conn);
                            OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader 
                            reader.Read();
                            string temp = reader["account"].ToString();
                            if (temp == ac)
                            {
                                num = x;
                                break;
                            }
                            reader.Close();
                        }

                        string mm = messageTemp[3].Trim(("\0".ToCharArray()));
                        string sql = "update Users set pw = '" + mm + "' where MyID=" + num + "";
                        //string sql = "update Users set pw = '321' where MyID=1";
                        OleDbCommand oleDbCom = new OleDbCommand(sql, conn);
                        oleDbCom.ExecuteNonQuery();
                        conn.Close();

                        Send(tIP, "successChange");
                    }
                    else if (cmd == "searchTicket")  //cmd为searchTicket，内容为空
                    {
                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i].account == ac)
                            {
                                if (users[i].ticketnum == 0)
                                    Send(tIP, "notickets");
                                else
                                {
                                    string mm = "";
                                    for (int j = 0; j < 5; j++)
                                    {
                                        if (users[i].ownTicket[j] != null)
                                        {
                                            mm += users[i].ownTicket[j].startStation + "/" + users[i].ownTicket[j].endStation + "/" + users[i].ownTicket[j].belong.trainNumber
                                            + "/" + users[i].ownTicket[j].comNumber + "/" + users[i].ownTicket[j].lineNumber + "/" + users[i].ownTicket[j].seatNumber + "/" +
                                            users[i].ownTicket[j].startTime + "/" + users[i].ownTicket[j].endTime + "/" + users[i].ownTicket[j].price + "#";
                                        }
                                    }
                                    mm = mm.Trim(("#".ToCharArray()));
                                    Send(tIP, mm);
                                }
                                break;
                            }
                        }
                    }
                    else if (cmd == "quitTicket")  //cmd为quitTicket，内容为 列车号/车厢号/排号/座号
                    {
                        string content = messageTemp[3].Trim(("\0".ToCharArray()));
                        string[] cc = content.Split('/');
                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i].account == ac)
                            {
                                int qq = 0;
                                Ticket temptic = null;
                                users[i].ticketnum -= 1;
                                for (int j = 0; j < 5; j++)
                                {
                                    if (users[i].ownTicket[j] != null)
                                    {
                                        if (users[i].ownTicket[j].belong.trainNumber == cc[0] && users[i].ownTicket[j].comNumber == cc[1] &&
                                        users[i].ownTicket[j].lineNumber == cc[2] && users[i].ownTicket[j].seatNumber == cc[3])
                                        {
                                            temptic = users[i].ownTicket[j];
                                            qq = j + 1;
                                            users[i].ownTicket[j] = null;
                                            break;
                                        }
                                    }
                                }

                                int aaa = Convert.ToInt32(temptic.comNumber);
                                int bbb = Convert.ToInt32(temptic.lineNumber);
                                int ccc = Convert.ToInt32(temptic.seatNumber);
                                temptic.belong.ticCollection[aaa - 1, bbb - 1, ccc - 1].buyed = false;

                                conn.Open();
                                string str1 = "select count(*) From Users";
                                OleDbCommand cmd1 = new OleDbCommand(str1, conn);
                                int n1 = (int)cmd1.ExecuteScalar();
                                int num = 0;

                                for (int iii = 0; iii < n1; iii++)
                                {
                                    int x = iii + 1;
                                    string strCom = "Select * from Users where MyID=" + x;
                                    OleDbCommand myCommand = new OleDbCommand(strCom, conn);
                                    OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader 
                                    reader.Read();
                                    string temp = reader["account"].ToString();
                                    if (temp == ac)
                                    {
                                        num = x;
                                    }
                                    reader.Close();
                                }

                                string sql = "update Users set ticket" + qq + " = '" + "" + "' where MyID=" + num + "";
                                OleDbCommand oleDbCom = new OleDbCommand(sql, conn);
                                oleDbCom.ExecuteNonQuery();
                                int tn = users[i].ticketnum;
                                string sql1 = "update Users set ticketnum = '" + tn + "' where MyID=" + num + "";
                                OleDbCommand oleDbCom1 = new OleDbCommand(sql1, conn);
                                oleDbCom1.ExecuteNonQuery();
                                string stime = temptic.startTime;
                                string etime = temptic.endTime;
                                string ss = temptic.belong.trainNumber + "/" + temptic.startStation + "/" + temptic.endStation + "/" +
                                    stime + "/" + etime + "/" + "未被购买";
                                string sql2 = "update TicketsOf" + temptic.belong.trainNumber + " set C" + temptic.comNumber
                                    + "Column" + temptic.seatNumber + " = '" + ss + "' where MyID=" + temptic.lineNumber + "";
                                OleDbCommand oleDbCom2 = new OleDbCommand(sql2, conn);
                                oleDbCom2.ExecuteNonQuery();
                                conn.Close();
                                Send(tIP, "successQuit");
                                break;
                            }
                        }
                    }
                    else if (cmd == "Lookingfor")  //cmd为buyTicket，内容为 起点站/终点站/列车号/出发日期
                    {
                        string content = messageTemp[3].Trim(("\0".ToCharArray()));
                        string[] info = content.Split('/');

                        int n = trains.LastNumber;
                        string mm = "";
                        int jud = 0;
                        if (info[2] == "" && info[0] == "" && info[1] == "")
                        {
                            for (int i = 0; i < n; i++)
                            {
                                int xx = 0;
                                int yy = Cn2(trains.GetValue(i + 1).passNumber);
                                for (int j = 0; j < yy; j++)
                                {
                                    for (int k = xx; k < trains.GetValue(i + 1).passStation.Length - 1; k++)
                                    {
                                        for (int qq = k + 1; qq < trains.GetValue(i + 1).passStation.Length; qq++)
                                        {
                                            mm += trains.GetValue(i + 1).trainNumber.ToString() + " ";
                                            mm += trains.GetValue(i + 1).passStation[k] + "/" + trains.GetValue(i + 1).passStation[qq];
                                            mm = mm.Trim(("/".ToCharArray()));
                                            mm += " " + trains.GetValue(i + 1).passNumber.ToString() + " " + trains.GetValue(i + 1).leftNum;
                                            mm += ";";
                                        }
                                        xx++;
                                    }
                                }
                            }
                            jud++;
                        }
                        else if (info[2] != "" && info[0] == "" && info[1] == "")
                        {
                            try
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    if (info[2] == trains.GetValue(i + 1).trainNumber.ToString())
                                    {
                                        int xx = 0;
                                        int yy = Cn2(trains.GetValue(i + 1).passNumber);
                                        for (int j = 0; j < yy; j++)
                                        {
                                            for (int k = xx; k < trains.GetValue(i + 1).passStation.Length - 1; k++)
                                            {
                                                for (int qq = k + 1; qq < trains.GetValue(i + 1).passStation.Length; qq++)
                                                {
                                                    mm += trains.GetValue(i + 1).trainNumber.ToString() + " ";
                                                    mm += trains.GetValue(i + 1).passStation[k] + "/" + trains.GetValue(i + 1).passStation[qq];
                                                    mm = mm.Trim(("/".ToCharArray()));
                                                    mm += " " + trains.GetValue(i + 1).passNumber.ToString() + " " + trains.GetValue(i + 1).leftNum;
                                                    mm += ";";
                                                }
                                                xx++;
                                            }
                                        }
                                        jud++;
                                    }
                                }
                            }
                            catch { }
                        }
                        else if (info[0] != "" && info[1] == "")
                        {
                            try
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    int xx = 0;
                                    int yy = Cn2(trains.GetValue(i + 1).passNumber);
                                    for (int j = 0; j < yy; j++)
                                    {
                                        for (int k = xx; k < trains.GetValue(i + 1).passStation.Length - 1; k++)
                                        {
                                            if (trains.GetValue(i + 1).passStation[k] == info[0])
                                            {
                                                for (int qq = k + 1; qq < trains.GetValue(i + 1).passStation.Length; qq++)
                                                {
                                                    mm += trains.GetValue(i + 1).trainNumber.ToString() + " ";
                                                    mm += trains.GetValue(i + 1).passStation[k] + "/" + trains.GetValue(i + 1).passStation[qq];
                                                    mm = mm.Trim(("/".ToCharArray()));
                                                    mm += " " + trains.GetValue(i + 1).passNumber.ToString() + " " + trains.GetValue(i + 1).leftNum;
                                                    mm += ";";
                                                }
                                                jud++;
                                            }
                                            xx++;
                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                        else if (info[0] == "" && info[1] != "")
                        {
                            try
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    int xx = 0;
                                    int yy = Cn2(trains.GetValue(i + 1).passNumber);
                                    for (int j = 0; j < yy; j++)
                                    {
                                        for (int k = xx; k < trains.GetValue(i + 1).passStation.Length - 1; k++)
                                        {
                                            for (int qq = k + 1; qq < trains.GetValue(i + 1).passStation.Length; qq++)
                                            {
                                                if (trains.GetValue(i + 1).passStation[qq] == info[1])
                                                {
                                                    mm += trains.GetValue(i + 1).trainNumber.ToString() + " ";
                                                    mm += trains.GetValue(i + 1).passStation[k] + "/" + trains.GetValue(i + 1).passStation[qq];
                                                    mm = mm.Trim(("/".ToCharArray()));
                                                    mm += " " + trains.GetValue(i + 1).passNumber.ToString() + " " + trains.GetValue(i + 1).leftNum;
                                                    mm += ";";
                                                    jud++;
                                                }
                                            }
                                            xx++;
                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                        else if (info[0] != "" && info[1] != "")
                        {
                            try
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    int xx = 0;
                                    int yy = Cn2(trains.GetValue(i + 1).passNumber);
                                    for (int j = 0; j < yy; j++)
                                    {
                                        for (int k = xx; k < trains.GetValue(i + 1).passStation.Length - 1; k++)
                                        {
                                            for (int qq = k + 1; qq < trains.GetValue(i + 1).passStation.Length; qq++)
                                            {
                                                if (trains.GetValue(i + 1).passStation[qq] == info[1] && trains.GetValue(i + 1).passStation[k] == info[0])
                                                {
                                                    mm += trains.GetValue(i + 1).trainNumber.ToString() + " ";
                                                    mm += trains.GetValue(i + 1).passStation[k] + "/" + trains.GetValue(i + 1).passStation[qq];
                                                    mm = mm.Trim(("/".ToCharArray()));
                                                    mm += " " + trains.GetValue(i + 1).passNumber.ToString() + " " + trains.GetValue(i + 1).leftNum;
                                                    mm += ";";
                                                    jud++;
                                                }
                                            }
                                            xx++;
                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                        if (jud != 0)
                        {
                            mm = mm.Trim((";".ToCharArray()));
                            Send(tIP, mm);
                        }
                        else
                        {
                            Send(tIP, "notFound");
                        }
                    }
                    else if (cmd == "buyTickets")
                    {
                        string content = messageTemp[3].Trim(("\0".ToCharArray()));
                        string[] info = content.Split('/');
                        Ticket temptic = null;
                        int zz = 0;
                        for(int q = 0; q < trains.LastNumber; q++)
                        {
                            if (info[0] == trains.GetValue(q + 1).trainNumber)
                            {
                                for(int aa = 0; aa<5 ; aa++)
                                {
                                    for(int bb = 0; bb < 8; bb++)
                                    {
                                        for(int cc = 0; cc < 5; cc++)
                                        {
                                            if(trains.GetValue(q + 1).ticCollection[aa,bb,cc].startStation==info[1]&& trains.GetValue(q + 1).ticCollection[aa, bb, cc].endStation == info[2])
                                            {
                                                temptic = trains.GetValue(q + 1).ticCollection[aa, bb, cc];
                                                trains.GetValue(q + 1).ticCollection[aa, bb, cc].buyed = true;
                                                zz++;
                                                break;
                                            }
                                        }
                                        if (zz != 0)
                                            break;
                                    }
                                    if (zz != 0)
                                        break;
                                }
                            }
                            if (zz != 0)
                                break;
                        }

                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i].account == ac)
                            {
                                users[i].ticketnum += 1;                              

                                conn.Open();
                                string str1 = "select count(*) From Users";
                                OleDbCommand cmd1 = new OleDbCommand(str1, conn);
                                int n1 = (int)cmd1.ExecuteScalar();
                                int num = 0;
                                string[] tic = new string[5];
                                int emptytic = 0;

                                for (int iii = 0; iii < n1; iii++)
                                {
                                    int x = iii + 1;
                                    string strCom = "Select * from Users where MyID=" + x;
                                    OleDbCommand myCommand = new OleDbCommand(strCom, conn);
                                    OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader 
                                    reader.Read();
                                    string temp = reader["account"].ToString();
                                    if (temp == ac)
                                    {
                                        num = x;
                                        tic[0]= reader["ticket1"].ToString();
                                        tic[1] = reader["ticket2"].ToString();
                                        tic[2] = reader["ticket3"].ToString();
                                        tic[3] = reader["ticket4"].ToString();
                                        tic[4] = reader["ticket5"].ToString();
                                    }
                                    reader.Close();
                                }

                                for(int j = 0; j < 5; j++)
                                {
                                    if (tic[j] == "")
                                    {
                                        emptytic = j + 1;
                                        break;
                                    }                                    
                                }
                                if (emptytic == 0)
                                {
                                    Send(tIP, "fullTicket");
                                }
                                else
                                {
                                    users[i].ownTicket[emptytic - 1] = temptic;
                                    string st = temptic.startTime;
                                    string et = temptic.endTime;
                                    string mess= temptic.belong.trainNumber
                                            + "/"+temptic.startStation + "/" + temptic.endStation + "/" + temptic.comNumber + "/" + temptic.lineNumber + "/" + temptic.seatNumber + "/" +
                                            st + "/" + et + "/" + temptic.price + " ";
                                    string sql = "update Users set ticket" + emptytic + " = '" + mess + "' where MyID=" + num + "";
                                    OleDbCommand oleDbCom = new OleDbCommand(sql, conn);
                                    oleDbCom.ExecuteNonQuery();
                                    int tn = users[i].ticketnum;
                                    string sql1 = "update Users set ticketnum = '" + tn + "' where MyID=" + num + "";
                                    OleDbCommand oleDbCom1 = new OleDbCommand(sql1, conn);
                                    oleDbCom1.ExecuteNonQuery();
                                    string stime = temptic.startTime;
                                    string etime = temptic.endTime;
                                    string ss = temptic.belong.trainNumber + "/" + temptic.startStation + "/" + temptic.endStation + "/" +
                                        stime + "/" + etime + "/" + "已被购买";
                                    string sql2 = "update TicketsOf" + temptic.belong.trainNumber + " set C" + temptic.comNumber
                                        + "Column" + temptic.seatNumber + " = '" + ss + "' where MyID=" + temptic.lineNumber + "";
                                    OleDbCommand oleDbCom2 = new OleDbCommand(sql2, conn);
                                    oleDbCom2.ExecuteNonQuery();
                                    conn.Close();
                                    Send(tIP, "successBuy");
                                    break;
                                }

                               
                            }
                        }
                    }
                    
                }
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("firewall says no no to" +
                "application - application cries..");
            }
            catch (Exception)
            {
                Console.WriteLine("stoped listening..");
            }
        }

        private void Send(string ip, string mm)
        {
            string stream = mm;
            try
            {
                TcpClient tcpc = new TcpClient(ip, 8001);
                //在8001端口新建一个TcpClient对象
                NetworkStream tcpStream = tcpc.GetStream();

                StreamWriter reqStreamW = new StreamWriter(tcpStream);
                reqStreamW.Write(stream);
                reqStreamW.Flush();//发送信息
                tcpStream.Close();
                tcpc.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("connection refused by target computer" + e.ToString());              
            }
        }

        private string TimeFormChange(string xx)
        {
            string[] temp = xx.Split('*');
            if (temp[1].Length == 1)
            {
                temp[1] = "0" + temp[1];
            }
            if (temp[2].Length == 1)
            {
                temp[2] = "0" + temp[2];
            }
            string[] tt = temp[3].Split(':');
            if (tt[0].Length == 1)
            {
                tt[0] = "0" + tt[0];
            }
            if (tt[1].Length == 1)
            {
                tt[1] = "0" + tt[1];
            }
            string rt = temp[0] + "-" + temp[1] + "-" + temp[2] + " " + tt[0] + ":" + tt[1];
            return rt;
        }

        private string TimeChanging(string xx)
        {
            string[] temp = xx.Split(' ');
            string[] t1 = temp[0].Split('-');
            if (t1[1].Substring(0, 1) == "0")
                t1[1] = t1[1].Substring(1, 1);
            if (t1[2].Substring(0, 1) == "0")
                t1[2] = t1[2].Substring(1, 1);
            string[] t2= temp[1].Split(':');
            if (t2[0].Substring(0, 1) == "0")
                t2[0] = t2[0].Substring(1, 1);
            if (t2[1].Substring(0, 1) == "0")
                t2[1] = t2[1].Substring(1, 1);
            string rt = t1[0] + "*" + t1[1] + "*" + t1[2] + "*" + t2[0] + "*" + t2[1];
            return rt;
        }

        private int Factorial(int n)  //n的阶乘
        {
            if (n == 1 || n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        private int Cn2(int n)  //求Cn2
        {
            return Factorial(n) / (Factorial(2) * Factorial(n - 2));
        }
    }

    
}

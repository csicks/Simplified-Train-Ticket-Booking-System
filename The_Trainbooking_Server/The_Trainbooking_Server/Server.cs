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

namespace The_Trainbooking_Server
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
        public IPAddress selfIP;
        private Thread th;
        private TcpListener tcpl;
        public bool listenerRun = true;
        //listenerRun为true，表示可以接受连接请求，false则为结束程序
        public string messageBox;

        public User[] users;
        public Linear<Train> trains;
        public Linear<TicketAndSoOn> tickets;

        public string TIP = "192.168.13.120";
        public string receive;

        public Server()
        {


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
                    tcpl = new TcpListener(ipAddress, 8001);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                tcpl.Start();
                //Console.WriteLine("started listening..");

                while (listenerRun)  //开始监听
                {
                    Socket s = tcpl.AcceptSocket();
                    string remotetemp = s.RemoteEndPoint.ToString();
                    Byte[] stream = new Byte[800];
                    int i = s.Receive(stream);  //接受连接请求的字节流
                    messageBox = System.Text.Encoding.UTF8.GetString(stream);
                    //Console.WriteLine(System.Text.Encoding.UTF8.GetString(stream));
                    string messageTemp = messageBox.Trim(("\0".ToCharArray()));
                    receive = messageTemp;
                    Exchange.loginNumber += 1;
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

        public void Send( string mm)//ip+account+cmd+内容
        {
            string stream = mm;
            try
            {
                TcpClient tcpc = new TcpClient(TIP, 5656);
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
    }
}

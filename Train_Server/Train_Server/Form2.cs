using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Train_Server
{
    public partial class Form2 : Form
    {
        Server server;
        OleDbConnection conn;
        bool sortState = true;

        public Form2()
        {           
            InitializeComponent();
            string address = "Provider=microsoft.ace.oledb.12.0;Data Source=C:\\Users\\john\\Desktop\\Database1.accdb;";
            conn = new OleDbConnection(address);
            server = new Server();

            conn.Open();

            string str1 = "select count(*) From Users";
            OleDbCommand cmd1 = new OleDbCommand(str1, conn);
            int n1 = (int)cmd1.ExecuteScalar();
            string str2= "select count(*) From Trains";
            OleDbCommand cmd2 = new OleDbCommand(str2, conn);
            int n2 = (int)cmd2.ExecuteScalar();

            server.users = new User[n1];
            Train[] temp = new Train[n2];

            Ticket[,,] comp = new Ticket[5, 8, 5];
            for (int i = 0; i < n2; i++)
            {
                int x = i + 1;
                string strCom = "Select * from Trains where MyID=" + x;
                OleDbCommand myCommand = new OleDbCommand(strCom, conn);
                OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader 
                reader.Read();
                string psta = reader["passStation"].ToString();
                string[] passStation = psta.Split('/');
                temp[i] = new Train(Convert.ToInt32(reader["passNumber"].ToString()), passStation, reader["number"].ToString(), comp, true);
                reader.Close();
            }
            server.trains = new Linear<Train>(temp);
            for (int i = 0; i < server.trains.LastNumber; i++)
                for (int j = 0; j < 5; j++)
                    for (int k = 0; k < 8; k++)
                        for(int t = 0; t < 5; t++)
                        {
                            int x = j + 1;
                            int y = k + 1;
                            int z = t + 1;
                            string strCom = "Select * from TicketsOf" + server.trains.GetValue(i + 1).trainNumber + " where MyID=" + y;
                            OleDbCommand myCommand = new OleDbCommand(strCom, conn);
                            OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader 
                            reader.Read();
                            string mm = reader["C" + x + "Column" + z + ""].ToString();
                            string[] qq1 = mm.Split('/');
                            string[] qq = new string[8];
                            if (qq1.Length != 1)
                            {
                                qq[0] = qq1[0];
                                qq[1] = x.ToString();
                                qq[2] = y.ToString();
                                qq[3] = z.ToString();
                                qq[4] = qq1[1];
                                qq[5] = qq1[2];
                                qq[6] = qq1[3];
                                qq[7] = qq1[4];
                                TrainTicketChanging(qq);
                            }
                            reader.Close();
                        }
                    
            for (int i = 0; i < n1; i++)
            {
                int x = i + 1;
                string strCom = "Select * from Users where MyID=" + x;
                OleDbCommand myCommand = new OleDbCommand(strCom, conn);
                OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader 
                reader.Read();
                server.users[i] = new User(reader["account"].ToString(), reader["pw"].ToString(), Convert.ToInt32(reader["priority"].ToString()),
                    Convert.ToInt32(reader["ticketnum"].ToString()), reader["name1"].ToString(), reader["phoneNumber"].ToString());              
                for (int j = 1; j <= 5; j++)
                {
                    string xx = "ticket" + j.ToString();
                    string yy = reader[xx].ToString();
                    string[] tt = yy.Split('/');
                    Train bel=null;
                    for(int k = 0; k < server.trains.LastNumber; k++)
                    {
                        if(tt[0]==server.trains.GetValue(k).trainNumber)
                        {
                            bel = server.trains.GetValue(k);
                            break;
                        }
                    }
                    if (tt.Length != 1) 
                        server.users[i].ownTicket[j - 1] = new Ticket(tt[1], tt[2], bel, tt[3], tt[4], tt[5], tt[6], tt[7], tt[8]);
                }
                reader.Close();
            }
         
            conn.Close();

            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                 
        }

        private void TrainTicketChanging(string[] qq)
        {
            Node<Train> q = server.trains.Head;
            while (qq[0] != q.Data.trainNumber)
            {
                q = q.Next;
            }
            int x1 = Convert.ToInt32(qq[1]);
            int x2 = Convert.ToInt32(qq[2]);
            int x3 = Convert.ToInt32(qq[3]);
            q.Data.ticCollection[x1 - 1, x2 - 1, x3 - 1] = new Ticket(qq[4], qq[5], q.Data, qq[1], qq[2], qq[3], qq[6], qq[7], null);
        }

        private void button1_Click(object sender, EventArgs e)  //列车查询
        {
            bool c1 = checkBox1.Checked;
            bool c2 = checkBox2.Checked;
            bool c3 = checkBox3.Checked;
            bool c4 = checkBox4.Checked;
            bool c5 = checkBox5.Checked;
            listView1.Items.Clear();
            listView1.BeginUpdate();
            int n = server.trains.LastNumber;
            if (textBox1.Text==""&& textBox2.Text == ""&& textBox3.Text == "") 
            {             
                for (int i = 0; i < n; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = (i + 1).ToString();
                    lvi.SubItems.Add(server.trains.GetValue(i + 1).trainNumber.ToString());
                    lvi.SubItems.Add(server.trains.GetValue(i + 1).passStation[0] + "/" +
                        server.trains.GetValue(i + 1).passStation[server.trains.GetValue(i + 1).passStation.Length - 1]);
                    lvi.SubItems.Add(server.trains.GetValue(i + 1).passNumber.ToString());
                    this.listView1.Items.Add(lvi);
                }
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                try
                {
                    int x = 1;
                    for (int i = 0; i < n; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        if (textBox1.Text == server.trains.GetValue(i + 1).trainNumber.ToString())
                        {
                            lvi.Text = x.ToString();
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).trainNumber.ToString());
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).passStation[0] + "/" +
                                server.trains.GetValue(i + 1).passStation[server.trains.GetValue(i + 1).passStation.Length - 1]);
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).passNumber.ToString());
                            this.listView1.Items.Add(lvi);
                            x++;
                        }
                    }
                }
                catch { }
            }
            else if (textBox2.Text != "" && textBox3.Text == "")
            {
                try
                {
                    int x = 1;
                    for (int i = 0; i < n; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        if (textBox2.Text == server.trains.GetValue(i + 1).passStation[0])
                        {
                            lvi.Text = x.ToString();
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).trainNumber.ToString());
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).passStation[0] + "/" + 
                                server.trains.GetValue(i + 1).passStation[server.trains.GetValue(i + 1).passStation.Length - 1]);
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).passNumber.ToString());
                            this.listView1.Items.Add(lvi);
                            x++;
                        }
                    }
                }
                catch { }
            }
            else if (textBox2.Text == "" && textBox3.Text != "")
            {
                try
                {
                    int x = 1;
                    for (int i = 0; i < n; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        if (textBox3.Text == server.trains.GetValue(i + 1).passStation[server.trains.GetValue(i + 1).passStation.Length - 1])
                        {
                            lvi.Text = x.ToString();
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).trainNumber.ToString());
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).passStation[0] + "/" +
                                server.trains.GetValue(i + 1).passStation[server.trains.GetValue(i + 1).passStation.Length - 1]);
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).passNumber.ToString());
                            this.listView1.Items.Add(lvi);
                            x++;
                        }
                    }
                }
                catch { }
            }
            else
            {
                try
                {
                    int x = 1;
                    for (int i = 0; i < n; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        if (textBox2.Text == server.trains.GetValue(i + 1).passStation[0]&&
                            textBox3.Text == server.trains.GetValue(i + 1).passStation[server.trains.GetValue(i).passStation.Length - 1])
                        {
                            lvi.Text = x.ToString();
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).trainNumber.ToString());
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).passStation[0] + "/" +
                                server.trains.GetValue(i).passStation[server.trains.GetValue(i + 1).passStation.Length - 1]);
                            lvi.SubItems.Add(server.trains.GetValue(i + 1).passNumber.ToString());
                            this.listView1.Items.Add(lvi);
                            x++;
                        }
                    }
                }
                catch { }
            }
            conn.Close();
            if (!c1)
            {
                int[] tt = new int[100];
                int k = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string mm = listView1.Items[i].SubItems[1].ToString();
                    if (mm.Contains("G"))
                    {
                        tt[k] = i;
                        k++;
                    }
                }
                for(int i = 0; i < k; i++)
                {
                    listView1.Items[tt[i] - i].Remove();
                }
            }
            if (!c2)
            {
                int[] tt = new int[100];
                int k = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string mm = listView1.Items[i].SubItems[1].ToString();
                    if (mm.Contains("D"))
                    {
                        tt[k] = i;
                        k++;
                    }
                }
                for (int i = 0; i < k; i++)
                {
                    listView1.Items[tt[i] - i].Remove();
                }
            }
            if (!c3)
            {
                int[] tt = new int[100];
                int k = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string mm = listView1.Items[i].SubItems[1].ToString();
                    if (mm.Contains("Z"))
                    {
                        tt[k] = i;
                        k++;
                    }
                }
                for (int i = 0; i < k; i++)
                {
                    listView1.Items[tt[i] - i].Remove();
                }
            }
            if (!c4)
            {
                int[] tt = new int[100];
                int k = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string mm = listView1.Items[i].SubItems[1].ToString();
                    if (mm.Contains("T"))
                    {
                        tt[k] = i;
                        k++;
                    }
                }
                for (int i = 0; i < k; i++)
                {
                    listView1.Items[tt[i] - i].Remove();
                }
            }
            if (!c5)
            {
                int[] tt = new int[100];
                int k = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string mm = listView1.Items[i].SubItems[1].ToString();
                    if (mm.Contains("K"))
                    {
                        tt[k] = i;
                        k++;
                    }
                }
                for (int i = 0; i < k; i++)
                {
                    listView1.Items[tt[i] - i].Remove();
                }
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Text = (i + 1).ToString();
            }
            listView1.EndUpdate();
            if (listView1.Items.Count == 0)
                MessageBox.Show("您查找的车次不存在！");
        }

        private void button2_Click(object sender, EventArgs e)  //用户查询
        {
            listView2.Items.Clear();
            listView2.BeginUpdate();
            int n = server.users.Length;
            if (textBox4.Text == "" && textBox5.Text == "")
            {
                for (int i = 0; i < n; i++)
                {
                    int x = i + 1;
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = x.ToString();
                    lvi.SubItems.Add(server.users[i].priority.ToString());
                    lvi.SubItems.Add(server.users[i].name);
                    lvi.SubItems.Add(server.users[i].account);
                    lvi.SubItems.Add(server.users[i].passWord);
                    lvi.SubItems.Add(server.users[i].phoneNumber);
                    lvi.SubItems.Add(server.users[i].ticketnum.ToString());
                    this.listView2.Items.Add(lvi);
                }
            }
            else if(textBox4.Text != "")
            {
                try
                {
                    int x = 1;
                    for (int i = 0; i < n; i++)
                    {
                        ListViewItem lvi = new ListViewItem();                     
                        if (textBox4.Text== server.users[i].account)
                        {
                            lvi.Text = x.ToString();
                            lvi.SubItems.Add(server.users[i].priority.ToString());
                            lvi.SubItems.Add(server.users[i].name);
                            lvi.SubItems.Add(server.users[i].account);
                            lvi.SubItems.Add(server.users[i].passWord);
                            lvi.SubItems.Add(server.users[i].phoneNumber);
                            lvi.SubItems.Add(server.users[i].ticketnum.ToString());
                            this.listView2.Items.Add(lvi);
                            x++;
                        }
                    }
                }
                catch { }
            }
            else
            {
                try
                {
                    int x = 1;
                    for (int i = 0; i < n; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        if (textBox5.Text == server.users[i].name)
                        {
                            lvi.Text = x.ToString();
                            lvi.SubItems.Add(server.users[i].priority.ToString());
                            lvi.SubItems.Add(server.users[i].name);
                            lvi.SubItems.Add(server.users[i].account);
                            lvi.SubItems.Add(server.users[i].passWord);
                            lvi.SubItems.Add(server.users[i].phoneNumber);
                            lvi.SubItems.Add(server.users[i].ticketnum.ToString());
                            this.listView2.Items.Add(lvi);
                            x++;
                        }
                    }
                }
                catch { }
            }
            conn.Close();
            listView2.EndUpdate();
            if (listView2.Items.Count == 0)
                MessageBox.Show("您查找的用户不存在！");
        }

        private void button3_Click(object sender, EventArgs e)  //用户排序
        {
            ListViewItem[] sets = new ListViewItem[listView2.Items.Count];
            for (int i = 0; i < listView2.Items.Count; i++) 
            {
                sets[i] = listView2.Items[i];
            }
            if (sortState)
            {
                for (int i = 0; i < sets.Length - 1; i++) 
                    for (int j = i; j >= 0; j--)
                        if (Convert.ToInt32(sets[j + 1].SubItems[1].Text) > Convert.ToInt32(sets[j].SubItems[1].Text))
                        {
                            ListViewItem temp = sets[j + 1];
                            sets[j + 1] = sets[j];
                            sets[j] = temp;
                        }
            }
            else
            {
                for (int i = 0; i < sets.Length - 1; i++)
                    for (int j = i; j >= 0; j--)
                        if (Convert.ToInt32(sets[j + 1].SubItems[1].Text) < Convert.ToInt32(sets[j].SubItems[1].Text))
                        {
                            ListViewItem temp = sets[j + 1];
                            sets[j + 1] = sets[j];
                            sets[j] = temp;
                        }
            }
            listView2.BeginUpdate();
            listView2.Items.Clear();
            for(int i = 0; i < sets.Length; i++)
            {
                int x = i + 1;
                sets[i].SubItems[0].Text = x.ToString();
            }
            for (int i=0;i< sets.Length; i++)
            {
                listView2.Items.Add(sets[i]);
            }
            listView2.EndUpdate();
            sortState = !sortState;            
        }

        private void button4_Click(object sender, EventArgs e)  //列车新增
        {
            Form3 form = new Form3(server);
            form.ShowDialog();

            if (Exchange.exStatus)
            {
                string[] t = Exchange.exArray;
                int pnum = Convert.ToInt32(t[1]);
                string[] psta = t[2].Split('/');
                string tnum = t[0];
                Ticket[,,] comp = new Ticket[5, 8, 5];
                Train temp = new Train(pnum, psta, tnum, comp, true);
                server.trains.Insert(100, temp);

                conn.Open();

                string sql1 = "select count(*) From " + "Trains";
                OleDbCommand cmd = new OleDbCommand(sql1, conn);
                int nn = (int)cmd.ExecuteScalar() + 1;

                //增
                string sql = "insert into [Trains](MyID,[number],passNumber,passStation)values('" + nn + "','" + t[0] + "','" + t[1] + "','" + t[2] + "')";
                //删 
                //string sql = "delete from 表名 where 字段1="...; 
                //改 
                //string sql = "update student set 学号=" ...; 


                OleDbCommand comm = new OleDbCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();

                listView1.Items.Clear();
                listView1.BeginUpdate();
                int n = server.trains.LastNumber;
                for (int i = 0; i < n; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = (i + 1).ToString();
                    lvi.SubItems.Add(server.trains.GetValue(i + 1).trainNumber.ToString());
                    lvi.SubItems.Add(server.trains.GetValue(i + 1).passStation[0] + "/" +
                        server.trains.GetValue(i + 1).passStation[server.trains.GetValue(i + 1).passStation.Length - 1]);
                    lvi.SubItems.Add(server.trains.GetValue(i + 1).passNumber.ToString());
                    this.listView1.Items.Add(lvi);
                }
                listView1.EndUpdate();
                Exchange.exStatus = false;
            }
            else
            {              
                if(Exchange.ticketStatus == true)
                {
                    conn.Open();
                    string dbstr = "DROP TABLE TicketsOf" + Exchange.exArray[0] + "";
                    OleDbCommand oleDbCom = new OleDbCommand(dbstr, conn);
                    oleDbCom.ExecuteNonQuery();
                    conn.Close();
                }
                Exchange.exArray[0] = null;
                Exchange.exArray[1] = null;
                Exchange.exArray[2] = null;
                Exchange.ticketStatus = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)  //列车删除
        {
            listView1.BeginUpdate();
            int currentIndex = 0;
            if (this.listView1.SelectedItems.Count > 0)//判断listview有被选中项
            {
                currentIndex = this.listView1.SelectedItems[0].Index;//取当前选中项的index

                conn.Open();

                string sql0 = "select count(*) From " + "Trains";
                OleDbCommand cmd = new OleDbCommand(sql0, conn);
                int nn = (int)cmd.ExecuteScalar();

                string sql = "delete from Trains where number=('" + this.listView1.SelectedItems[0].SubItems[1].Text + "')";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                comm.ExecuteNonQuery();

                int xx = Convert.ToInt32(this.listView1.SelectedItems[0].Text);
                if (xx < nn)
                {
                    for (int i = xx + 1; i <= nn; i++)
                    {
                        string sql1 = "update Trains set MyID = (" + (i - 1) + ") where MyID = (" + i + ")";
                        OleDbCommand comm1 = new OleDbCommand(sql1, conn);
                        comm1.ExecuteNonQuery();
                    }
                }

                try
                {
                    string dbstr = "DROP TABLE TicketsOf" + this.listView1.SelectedItems[0].SubItems[1].Text + "";
                    OleDbCommand oleDbCom = new OleDbCommand(dbstr, conn);
                    oleDbCom.ExecuteNonQuery();
                }
                catch
                {

                }

                conn.Close();
              
                string tnum = this.listView1.SelectedItems[0].SubItems[1].Text;
                int pos = -1;
                for(int i = 0; i < server.trains.LastNumber; i++)
                {
                    if (server.trains.GetValue(i + 1).trainNumber == tnum)
                        pos = i + 1;
                }
                server.trains.Delete(pos);

                listView1.Items[currentIndex].Remove();

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].Text = (i + 1).ToString();
                }
            }
            listView1.EndUpdate();
        
        }

        private void button6_Click(object sender, EventArgs e)  //用户购票详细信息
        {
            if (this.listView2.SelectedItems.Count > 0)
            {
                User temp = null;
                string ac = listView2.SelectedItems[0].SubItems[3].Text;
                for(int i = 0; i < server.users.Length; i++)
                {
                    if (server.users[i].account == ac)
                    {
                        temp = server.users[i];
                        break;
                    }
                }
                if (temp.ticketnum > 0)
                {
                    Form4 form = new Form4(temp);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("该用户没有购票信息！");
            }
        }

        private void button7_Click(object sender, EventArgs e)  //车票规划
        {
            if (this.listView1.SelectedItems.Count > 0)//判断listview有被选中项
            {
                string num= this.listView1.SelectedItems[0].SubItems[1].Text;
                Exchange.exArray[0] = this.listView1.SelectedItems[0].SubItems[1].Text; 
                Exchange.exArray[1] = this.listView1.SelectedItems[0].SubItems[3].Text;
                for(int i = 0; i < server.trains.LastNumber; i++)
                {
                    if (this.listView1.SelectedItems[0].SubItems[1].Text == server.trains.GetValue(i + 1).trainNumber)
                    {
                        string mm = null;
                        for(int j=0;j< server.trains.GetValue(i + 1).passStation.Length; j++)
                        {
                            mm += server.trains.GetValue(i + 1).passStation[j] + "/";
                        }
                        mm = mm.Substring(0, mm.Length - 1);
                        Exchange.exArray[2] = mm;
                        break;
                    }
                }
                Form5 form = new Form5(server);
                form.ShowDialog();

                try
                {
                    string[] qq = Exchange.exTicInfo.Split('/');
                    TrainTicketChanging(qq);
                }
                catch { }

                Exchange.exArray[0] = null;
                Exchange.exArray[1] = null;
                Exchange.exArray[2] = null;
            }
                
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Stop();
        }
    }
}

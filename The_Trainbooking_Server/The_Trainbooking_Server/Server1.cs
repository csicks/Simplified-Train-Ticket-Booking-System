using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Trainbooking_Server
{
    public partial class Server1 : Form
    {
        private bool mode;//mode变量决定是否让客户端生效，当账号密码正确时，mode=true,否则mode=false
        public string numbers;
        public string name;
        public string pnumber;
        public string tnumber;
        public string pw;
        public Server server;

        public Server1(Server s)
        {
            server = s;
            InitializeComponent();
            mode = true;//初始化mode为false
        }
        public void NumberChange(string info)//修改类中账号为登录账号
        {
            string[] temp = info.Split(' ');
            numbers = temp[0];
            name = temp[2];
            pnumber = temp[3];
            tnumber = temp[4];
            pw = temp[6];

        }
        public bool Form_Checkmode()
        {
            if(mode==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Form_Closemode()
        {
            mode = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basic_information Basic = new Basic_information();
            
            Basic.Load_ticket();
            Basic.LoadInformation();
            Basic.Number_Change(numbers, name, pnumber, tnumber, pw, server);
            Basic.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mm = server.selfIP + " " + Exchange.account + " " + "searchTicket";
            server.Send(mm);
            int oldnum = Exchange.loginNumber;
            while (oldnum == Exchange.loginNumber) { }
            if (server.receive == "notickets")
            {
                MessageBox.Show("您还没有购票信息！");
            }
            else
            {
                string[] tic = server.receive.Split('#');
                Ticket_Information Tic = new Ticket_Information(tic, server);
                Tic.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket_Booking Book = new Ticket_Booking(server);
            Book.Show();
        }
    }
}

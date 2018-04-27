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
    public partial class Basic_information : Form
    {
        private string ID;//身份证号
        private string number;//账号
        private string code;//密码
        private int statue_class;//优先级
        private string name;//姓名
        private Ticket ticket;//车票类
        private int tick_num;//车票数
        private string phone;
        private Server server;
        public Basic_information()
        {
            InitializeComponent();
            ID = null;
            number = null;
            code = null;
            statue_class = 0;
            name = null;
            tick_num = 0;
            label6.Text = number;
        }
        public void Number_Change(string numbers, string name, string pnumber, string tnumber, string pw, Server s)//修改即将输出的账号名为登录账号名
        {
            this.number = numbers;
            this.name = name;
            this.phone = pnumber;
            this.tick_num = Convert.ToInt32(tnumber);
            this.code = pw;
            this.server = s;
            label6.Text = number;
            label7.Text = name;
            label9.Text = phone;
            label10.Text = tick_num.ToString();
        }

       // private string ToString1(long phone)
        //{
         //   MessageBox.Show("您输入的密码错误！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹出提示窗口
            //return string.ToString(phone);
        //}

        public void LoadInformation()//从数据库获取用户信息
        {
            name ="轩轩";
            ID = "42658169720822";
            statue_class = 0;
            tick_num = 5;
            phone = "16751649983";
        }
        public void Load_ticket()//从数据库获得信息
        {

            //tick_num=ticket1.Length();
        }
        private void Basic_information_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check cc = new check(code, server, number);
            cc.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mm = server.selfIP + " " + Exchange.account + " " + "searchTicket";
            server.Send(mm);
            int oldnum = Exchange.loginNumber;
            while (oldnum == Exchange.loginNumber) { }
            if (server.receive=="notickets")
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
    }
    public class Ticket
    {
        public string Dest_A;
        public string Dest_B;
        public string Train_name;
        public string Site;
        public string Start_time;
        public string End_time;
        public double Price; 
    }
}

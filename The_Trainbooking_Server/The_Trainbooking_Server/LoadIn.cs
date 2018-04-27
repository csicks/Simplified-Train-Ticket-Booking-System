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
    public partial class LoadIn : Form//命令：login
    {
        public string ID1;//登录的账号
        private string passcode;//密码
        Server one = new Server();
        public LoadIn()
        {
            InitializeComponent();
            ID1 = null;
            passcode = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//button1是登录按钮
        {
            //button按下后会将账号密码传至服务器
            ID1 = textBox1.Text;
            passcode = textBox2.Text;
            string mm = one.selfIP + " " + ID1 + " " + "login " + passcode;
            one.Send(mm);
            Server1 Form1 = new Server1(one);//创建新窗体但不将其显示出来            
            int oldNumber = Exchange.loginNumber;
            while (oldNumber == Exchange.loginNumber) { }
            string jud = one.receive;
            if (one.receive.Contains(' '))
            {
                jud = one.receive.Split(' ')[0];
            }
            if (jud == "allow")
            {
                //Form1.MdiParent = this;
                this.Hide();//隐藏登录界面
                Form1.Show();//显示客户端窗口
                             //Application.Run(new Server1());
                Form1.Form_Closemode();//mode置0
                string mmm = ID1 + " " + one.receive + " " + passcode;
                Exchange.account = ID1;
                Form1.NumberChange(mmm);//记录登录信息
            }
            else if (jud == "refuse")
            {
                Form1.Close();//如果输入密码错误，关闭客户端窗口
                MessageBox.Show("您输入的密码错误！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹出提示窗口
                //this.Show();
                //this.InitializeComponent();//初始化登录界面
                //ID1 = null;//初始化输入的账号
                //passcode = null;//初始化输入的密码
            }
            else if (jud == "notlegal")
            {
                Form1.Close();//如果输入密码错误，关闭客户端窗口
                MessageBox.Show("用户名不存在！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹出提示窗口
                //this.Show();
                //this.InitializeComponent();//初始化登录界面
                //ID1 = null;//初始化输入的账号
                //passcode = null;//初始化输入的密码
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            one.Stop();
            this.Dispose();
        }
    }
}

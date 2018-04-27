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
    public partial class check : Form
    {
        string password;
        string account;
        Server server;
        public check(string xx, Server s, string yy)
        {
            password = xx;
            server = s;
            account = yy;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != password)
                MessageBox.Show("您输入的密码不正确！");
            else if (textBox2.Text == "")
                MessageBox.Show("新密码不能为空！");
            else
            {
                string mm = server.selfIP + " " + account + " " + "changePW" + " " + textBox2.Text;
                server.Send(mm);
                int oldnumber = Exchange.loginNumber;
                while(oldnumber == Exchange.loginNumber) { }
                if (server.receive == "successChange")
                    MessageBox.Show("密码修改成功！");
            }
        }
    }
}

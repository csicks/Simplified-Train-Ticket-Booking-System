using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Server
{
    public partial class Form1 : Form
    {
        string passWord = "abc123";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == passWord)
            {
                this.DialogResult = DialogResult.No;
            }
            else
            {
                MessageBox.Show("密码不正确！");
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.PasswordChar = '\0';
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (textBox1.Text == passWord)
                {
                    this.DialogResult = DialogResult.No;
                }
                else
                {
                    MessageBox.Show("密码不正确！");
                }
            }
        }

    }
}

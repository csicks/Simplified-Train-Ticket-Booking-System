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
    public partial class Ticket_Information : Form
    {
        string[] tic;
        Server server;
        public Ticket_Information(string[] xx, Server s)
        {
            InitializeComponent();
            tic = xx;
            server = s;
            string[,] sh = new string[tic.Length, 3];
            for(int i = 0; i < tic.Length; i++)
            {
                string[] tt = tic[i].Split('/');
                sh[i, 0] = tt[2];
                sh[i, 1] = tt[0];
                sh[i, 2] = tt[1];
                string mm = sh[i, 0] + " " + sh[i, 1] + "<——>" + sh[i, 2];
                Information_Text.Items.Add(mm);

            }                    
        }

        private void Ticket_Information_Load(object sender, EventArgs e)
        {
            //我也不知道是干啥的
        }

        private void TicketInformatinLoad()
        {
            string mm = server.selfIP + " " + Exchange.account + " " + "searchTicket";
            server.Send(mm);
            int oldnum = Exchange.loginNumber;
            while (oldnum == Exchange.loginNumber) { }
            tic = server.receive.Split('#');

            Information_Text.Items.Clear();
            string[,] sh = new string[tic.Length, 3];
            for (int i = 0; i < tic.Length; i++)
            {
                string[] tt = tic[i].Split('/');
                if(tt[0]=="notickets")
                {
                    Information_Text.Items.Clear();
                }
                else
                {
                    sh[i, 0] = tt[2];
                    sh[i, 1] = tt[0];
                    sh[i, 2] = tt[1];
                    string mm1 = sh[i, 0] + " " + sh[i, 1] + "<——>" + sh[i, 2];
                    Information_Text.Items.Add(mm1);
                }
                //Information_Text.Refresh();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            Information_Text.ClearSelected();
            TicketInformatinLoad();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] sh = new string[tic.Length, 3];
            for (int i = 0; i < tic.Length; i++)
            {
                string[] tt = tic[i].Split('/');
                sh[i, 0] = tt[2];
                sh[i, 1] = tt[0];
                sh[i, 2] = tt[1];
            }
            for(int i = 0; i < tic.Length; i++)
            {
                if(sh[i,0]==Information_Text.SelectedItem.ToString().Split(' ')[0])
                {
                    string[] temp = tic[i].Split('/');
                    string st = temp[6].Split('*')[0] + "-" + temp[6].Split('*')[1] + "-" + temp[6].Split('*')[2] + " " + temp[6].Split('*')[3];
                    string et = temp[7].Split('*')[0] + "-" + temp[7].Split('*')[1] + "-" + temp[7].Split('*')[2] + " " + temp[7].Split('*')[3];
                    MessageBox.Show("列车号：" + temp[2] + '\n' + "出发地：" + temp[0] + '\n' + "目的地：" + temp[1] + '\n' +
                        "出发时间：" + st + '\n' + "到达时间：" + et + '\n' + "座位号：" + temp[3] + "车厢" + temp[4] +
                        "排" + temp[5] + "座" + '\n' + "票价：" + temp[8]);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(Information_Text.SelectedItem==null)
            {
                MessageBox.Show("请选择您需要退的车票！");
                return;
            }
            string[,] sh = new string[tic.Length, 3];
            string[] zz = new string[4];
            for (int i = 0; i < tic.Length; i++)
            {
                string[] tt = tic[i].Split('/');
                sh[i, 0] = tt[2];
                sh[i, 1] = tt[0];
                sh[i, 2] = tt[1];
            }
            for (int i = 0; i < tic.Length; i++)
            {
                if (sh[i, 0] == Information_Text.SelectedItem.ToString().Split(' ')[0])
                {
                    string[] temp = tic[i].Split('/');
                    zz[0] = temp[3];
                    zz[1] = temp[4];
                    zz[2] = temp[5];
                    zz[3] = temp[2];
                }
            }
            string mm = server.selfIP + " " + Exchange.account + " " + "quitTicket" +" "+ zz[3] + "/" + zz[0] + "/" + zz[1] + "/" + zz[2];
            server.Send(mm);
            int oldnum = Exchange.loginNumber;
            while(oldnum == Exchange.loginNumber) { }
            if (server.receive == "successQuit")
            {
                MessageBox.Show("退票成功！");
            }
            Information_Text.Items.RemoveAt(Information_Text.SelectedIndex);
           // Information_Text.Items.Remove(Information_Text.SelectedItems);
            //Information_Text.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ticket_Booking Book = new Ticket_Booking(server);
            Book.Show();
        }
    }
}

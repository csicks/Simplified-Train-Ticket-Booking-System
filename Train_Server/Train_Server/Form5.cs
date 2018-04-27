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
    public partial class Form5 : Form
    {
        Server server;
        Train train;
        public Form5(Server nserver)
        {
            InitializeComponent();
            server = nserver;
            for(int i = 0; i < server.trains.LastNumber; i++)
            {
                if(server.trains.GetValue(i+1).trainNumber== Exchange.exArray[0])
                {
                    train = server.trains.GetValue(i + 1);
                    break;
                }
            }
            //for(int i = 0; i < 5; i++) 
            //    for(int j = 0; j < 8; j++) 
            //        for(int k = 0; k < 5; k++) 
            //        {
            //            if (train.ticCollection[i, j, k] != null)
            //            {
            //                string s = "c" + (i + 1).ToString() + "l" + (j + 1).ToString() + "n" + (k + 1).ToString();
            //                this.GetType().GetField(s).SetValue(this, "rrrrrrrr");
            //            }
            //        }
        }

        private void c1_l1_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l1_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l1_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l2_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l2_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l2_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l3_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l3_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l3_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] =3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l4_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l4_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l4_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] =4;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l5_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l5_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l5_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();

        }

        private void c1_l6_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l6_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l6_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l7_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l7_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l7_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l8_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l8_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l8_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l1_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l1_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l2_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] =2;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l2_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l3_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] =3;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l3_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l4_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l4_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l5_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] =5;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l6_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l6_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l7_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l7_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l8_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c1_l8_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 1;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l1_n1_Click(object sender, EventArgs e)
        {
             Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l1_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l1_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l1_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l1_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l2_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l2_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l2_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l2_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l2_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l3_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l3_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l3_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l3_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l3_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l4_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l4_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l4_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l4_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l4_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l5_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l5_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] =2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l5_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l5_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l5_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l6_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l6_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l6_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l6_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l6_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l7_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l7_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l7_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l7_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l7_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l8_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l8_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l8_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l8_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c2_l8_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 2;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l1_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l1_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l1_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l1_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l1_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l2_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l2_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l2_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l2_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l2_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l3_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l3_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l3_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l3_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l3_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();

        }

        private void c3_l4_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l4_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l4_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l4_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l4_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l5_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l5_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l5_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l5_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l5_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l6_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l6_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l6_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l6_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l6_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l7_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l7_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] =7;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l7_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l7_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l7_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l8_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l8_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l8_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l8_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c3_l8_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 3;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l1_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l1_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l1_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l1_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l1_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l2_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l2_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l2_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l2_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l2_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l3_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l3_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l3_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l3_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l3_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l4_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l4_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l4_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l4_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l4_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l5_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l5_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l5_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l5_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l5_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l6_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l6_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l6_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l6_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l6_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l7_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l7_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l7_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l7_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l7_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l8_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l8_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l8_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l8_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c4_l8_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 4;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l1_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l1_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l1_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l1_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l1_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 1;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l2_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l2_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l2_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l2_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l2_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 2;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l3_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] =3;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l3_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l3_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l3_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l3_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 3;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l4_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l4_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l4_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l4_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l4_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 4;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l5_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l5_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l5_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l5_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l5_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 5;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l6_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l6_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l6_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l6_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l6_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 6;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l7_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l7_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l7_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l7_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l7_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 7;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l8_n1_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 1;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l8_n2_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 2;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l8_n3_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 3;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l8_n4_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 4;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void c5_l8_n5_Click(object sender, EventArgs e)
        {
            Exchange.bnum[0] = 5;
            Exchange.bnum[1] = 8;
            Exchange.bnum[2] = 5;
            Exchange.exTicInfo = Exchange.exArray[0] + "/" + Exchange.bnum[0] + "/" + Exchange.bnum[1] + "/" + Exchange.bnum[2] + "/";
            Form6 form = new Form6();
            form.ShowDialog();
        }
    }
}

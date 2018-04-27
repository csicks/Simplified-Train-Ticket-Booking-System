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
    public partial class Form4 : Form
    {
        User uu;
        public Form4(User temp)
        {
            uu = temp;
            InitializeComponent();
            label2.Text = uu.name;
            int validNum = 0;
            while (uu.ownTicket[validNum] != null)
                validNum++;
            for (int i = 0; i < validNum; i++)
            {
                string[] st = uu.ownTicket[i].startTime.Split('*');
                string[] et = uu.ownTicket[i].endTime.Split('*');
                string mm1 = (i + 1).ToString() + "." + "列车号： " + uu.ownTicket[i].belong.trainNumber;
                string mm2 = "起点站/终点站： " + uu.ownTicket[i].startStation + "/" + uu.ownTicket[i].endStation;
                string mm3 = "出发时间：" + st[0] + "/" + st[1] + "/" + st[2] + "  " + st[3];
                string mm4 = "到达时间：" + et[0] + "/" + et[1] + "/" + et[2] + "  " + et[3];
                string mm5 = "车厢号：" + uu.ownTicket[i].comNumber + "  " + uu.ownTicket[i].lineNumber + "排" + uu.ownTicket[i].seatNumber + "号";
                string mm6 = "票价： " + uu.ownTicket[i].price;
                string mm7 = "";
                listBox1.Items.Add(mm1);
                listBox1.Items.Add(mm2);
                listBox1.Items.Add(mm3);
                listBox1.Items.Add(mm4);
                listBox1.Items.Add(mm5);
                listBox1.Items.Add(mm6);
                listBox1.Items.Add(mm7);
            }            
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black; //初始化字体颜色=黑色  
            this.listBox1.ItemHeight = 20; //设置项高，根据具体需要设置值  
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, null);
            //这句好象可以不要，自己试下  
            e.DrawFocusRectangle();
        }
    }
}

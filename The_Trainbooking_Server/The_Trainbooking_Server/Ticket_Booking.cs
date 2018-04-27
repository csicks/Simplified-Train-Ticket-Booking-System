using System;
using System.Data.OleDb;
using System.Windows.Forms;


namespace The_Trainbooking_Server
{
    public partial class Ticket_Booking : Form
    {
        Server server;
        OleDbConnection conn;

        public Ticket_Booking(Server s)
        {
            InitializeComponent();
            server = s;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//点击查询按钮
        {
            string mm = server.selfIP + " " + Exchange.account + " " + "Lookingfor" + " " + textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text;
            server.Send(mm);
            int oldNum = Exchange.loginNumber;
            while (oldNum == Exchange.loginNumber) { }
            if (server.receive=="notFound")
            {
                listView1.BeginUpdate();
                listView1.Items.Clear();
                listView1.EndUpdate();
                MessageBox.Show("您查找的车次不存在！");
            }
            else
            {
                string[] temp = server.receive.Split(';');
                int x = 1;
                listView1.BeginUpdate();
                listView1.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                {
                    string[] sh = temp[i].Split(' ');
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = x.ToString();
                    lvi.SubItems.Add(sh[0]);
                    lvi.SubItems.Add(sh[1]);
                    //lvi.SubItems.Add(sh[2]);
                    lvi.SubItems.Add(sh[3]);
                    this.listView1.Items.Add(lvi);
                    x++;
                }
                listView1.EndUpdate();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择购票车次！");
            }
            else
            {
                string mm = server.selfIP + " " + Exchange.account + " " + "buyTickets" + " ";
                mm += listView1.SelectedItems[0].SubItems[1].Text + "/" + listView1.SelectedItems[0].SubItems[2].Text;
                server.Send(mm);
                int oldNum = Exchange.loginNumber;
                while (oldNum == Exchange.loginNumber) { }
                if (server.receive == "successBuy")
                    MessageBox.Show("购票成功！");
            }
        }
    }
}

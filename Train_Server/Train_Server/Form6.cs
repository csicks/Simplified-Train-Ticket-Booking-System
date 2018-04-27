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
    public partial class Form6 : Form
    {
        OleDbConnection conn;

        public Form6()
        {
            string address = "Provider=microsoft.ace.oledb.12.0;Data Source=C:\\Users\\john\\Desktop\\Database1.accdb;";
            conn = new OleDbConnection(address);

            InitializeComponent();
            string[] sta = Exchange.exArray[2].Split('/');
            for (int i = 0; i < sta.Length; i++)
            {
                this.comboBox1.Items.Add(sta[i]);
            }
            for (int i = 0; i < sta.Length; i++)
            {
                this.comboBox2.Items.Add(sta[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mm = Exchange.exArray[0] + "/" + comboBox1.SelectedItem + "/" + comboBox2.SelectedItem + "/" + dateTimePicker1.Text + "/" + dateTimePicker2.Text + "/" + "已被购买";
            //string sql = "update  [TicketsOf" + Exchange.exArray[0] + "] where MyID=" + Exchange.bnum[1] + " (Column"+ Exchange.bnum[2] + "])values('" + mm + "')";

            string sql= "update TicketsOf" + Exchange.exArray[0] + " set C" + Exchange.bnum[0] + "Column" + Exchange.bnum[2] + " = '" + mm + "' where MyID=" + Exchange.bnum[1] + "";
            conn.Open();
            OleDbCommand oleDbCom = new OleDbCommand(sql, conn);
            oleDbCom.ExecuteNonQuery();
            conn.Close();

            Exchange.exTicInfo += comboBox1.SelectedItem + "/" + comboBox2.SelectedItem + "/" + dateTimePicker1.Text + "/" + dateTimePicker2.Text;

            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            conn.Open();           
            string strCom = "Select * from TicketsOf" + Exchange.exArray[0] + " where MyID=" + Exchange.bnum[1];
            OleDbCommand myCommand = new OleDbCommand(strCom, conn);
            OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader 
            reader.Read();
            string temp = "C" + Exchange.bnum[0] + "Column" + Exchange.bnum[2];
            string psta = reader[temp].ToString();
            conn.Close();

            if (psta == "")
            {
                MessageBox.Show("当前车票无原始规划信息！");
            }
            else
            {
                string[] mes = psta.Split('/');
                string sh = "列车号：" + mes[0] + '\n' + "出发地：" + mes[1] + '\n' + "目的地：" + mes[2] + '\n' + "出发时间：" + mes[3] + '\n' + "到达时间：" + mes[4] + '\n' + "买票状态：" + mes[5];
                MessageBox.Show(sh);
            }
        }
    }
}

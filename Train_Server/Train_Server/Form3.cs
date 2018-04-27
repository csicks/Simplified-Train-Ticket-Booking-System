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
    public partial class Form3 : Form
    {
        OleDbConnection conn;
        Server server;

        public Form3(Server nserver)
        {
            string address = "Provider=microsoft.ace.oledb.12.0;Data Source=C:\\Users\\john\\Desktop\\Database1.accdb;";
            conn = new OleDbConnection(address);
            server = nserver;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] result = new string[3];
            result[0] = textBox1.Text;
            result[1] = textBox2.Text;
            result[2] = textBox3.Text;
            Exchange.exArray = result;
            Exchange.exStatus = true;

            try
            {
                conn.Open();
                string dbstr = "CREATE TABLE TicketsOf" + result[0] + "(MyID INTEGER, C1Column1 TEXT(50), C1Column2 TEXT(50), C1Column3 TEXT(50), C1Column4 TEXT(50), C1Column5 TEXT(50), C2Column1 TEXT(50), C2Column2 TEXT(50), C2Column3 TEXT(50), C2Column4 TEXT(50), C2Column5 TEXT(50), C3Column1 TEXT(50), C3Column2 TEXT(50), C3Column3 TEXT(50), C3Column4 TEXT(50), C3Column5 TEXT(50), C4Column1 TEXT(50), C4Column2 TEXT(50), C4Column3 TEXT(50), C4Column4 TEXT(50), C4Column5 TEXT(50), C5Column1 TEXT(50), C5Column2 TEXT(50), C5Column3 TEXT(50), C5Column4 TEXT(50), C5Column5 TEXT(50))";
                OleDbCommand oleDbCom = new OleDbCommand(dbstr, conn);
                oleDbCom.ExecuteNonQuery();
                for (int i = 0; i < 8; i++)
                {
                    int x = i + 1;
                    string sql = "insert into [TicketsOf" + result[0] + "]([MyID])values('" + x + "')";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch
            {

            }

            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] result = new string[3];
            result[0] = textBox1.Text;
            result[1] = textBox2.Text;
            result[2] = textBox3.Text;
            Exchange.exArray = result;

            try
            {
                conn.Open();
                string dbstr = "CREATE TABLE TicketsOf" + result[0] + "(MyID INTEGER, C1Column1 TEXT(50), C1Column2 TEXT(50), C1Column3 TEXT(50), C1Column4 TEXT(50), C1Column5 TEXT(50), C2Column1 TEXT(50), C2Column2 TEXT(50), C2Column3 TEXT(50), C2Column4 TEXT(50), C2Column5 TEXT(50), C3Column1 TEXT(50), C3Column2 TEXT(50), C3Column3 TEXT(50), C3Column4 TEXT(50), C3Column5 TEXT(50), C4Column1 TEXT(50), C4Column2 TEXT(50), C4Column3 TEXT(50), C4Column4 TEXT(50), C4Column5 TEXT(50), C5Column1 TEXT(50), C5Column2 TEXT(50), C5Column3 TEXT(50), C5Column4 TEXT(50), C5Column5 TEXT(50))";
                OleDbCommand oleDbCom = new OleDbCommand(dbstr, conn);
                oleDbCom.ExecuteNonQuery();
                for (int i = 0; i < 8; i++)
                {
                    int x = i + 1;
                    string sql = "insert into [TicketsOf" + result[0] + "]([MyID])values('" + x + "')";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch
            {

            }
            Exchange.ticketStatus = true;

            Form5 form = new Form5(server);
            form.ShowDialog();
        }
    }
}

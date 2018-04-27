using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Server
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.No)
            {
                form.Dispose();
                //Application.Run(new Form2());       
                Form2 nform = new Form2();
                nform.ShowDialog();
            }
            
        }
    }
}

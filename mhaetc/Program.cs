using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mhaetc
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
            Form_Login fr = new Form_Login();
            if (fr.ShowDialog() == DialogResult.OK)
            {

                Application.Run(new Main());
            }
        }
    }
}

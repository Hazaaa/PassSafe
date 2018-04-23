using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassSafe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //If is universal password set then open PasswordForm
            String folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PassSafe";
            if (File.Exists(folderPath + "\\dump.txt"))
            {
                Application.Run(new PasswordForm());
            }
            else
            {
                Application.Run(new FirstTimeForm());
            }
        }
    }
}

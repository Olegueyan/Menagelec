using System;
using System.Windows.Forms;
using Menagelec.Data;
using Menagelec.Service;

namespace Menagelec
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseService.InitializeService(new MysqlParameters
            {
                Host = "localhost",
                Port = "3306",
                Database = "menagelec",
                User = "admin",
                Password = "ubTroTJBi08LCeR"
            });
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
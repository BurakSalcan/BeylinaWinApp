using BeylinaWinApp.Giriş;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeylinaWinApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GirisSecim scm = new GirisSecim();
            if (scm.ShowDialog() == DialogResult.OK) // Giriş başarılı olduysa
            {
                Application.Run(new AnaForm()); // AnaForm'u başlat
            }
        }
    }
}

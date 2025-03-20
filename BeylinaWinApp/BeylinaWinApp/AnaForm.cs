using BeylinaWinApp.Giriş;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeylinaWinApp
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            MessageBox.Show("AnaForm Açıldı");
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Form uyeGirisFormu = Application.OpenForms["UyeGiris"];

            foreach (Form form in Application.OpenForms)
            {
                if (uyeGirisFormu != null)
                {
                    uyeGirisFormu.Hide();
                    uyeGirisFormu.Close();
                }

                //if (form is UyeGiris)
                //{
                //    form.Hide();
                //    form.Close();
                //    break;
                //}
            }
        }
    }
}

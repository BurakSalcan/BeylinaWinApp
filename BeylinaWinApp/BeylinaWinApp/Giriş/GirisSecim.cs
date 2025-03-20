using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeylinaWinApp.Giriş
{
    public partial class GirisSecim : Form
    {
        public GirisSecim()
        {
            InitializeComponent();
        }

        private void btn_uyeSecim_Click(object sender, EventArgs e)
        {
            UyeGiris uyeGrs = new UyeGiris();
            this.Hide();
            uyeGrs.ShowDialog();
            this.Close();
        }

        private void btn_calisanSecim_Click(object sender, EventArgs e)
        {
            CalisanGiris calGrs = new CalisanGiris();
            this.Hide();
            calGrs.ShowDialog();
            this.Close();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisSecim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

using BeylinaWinApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeylinaWinApp.Çalışan_Paneli
{
    public partial class KullaniciBilgileri : Form
    {
        public KullaniciBilgileri()
        {
            InitializeComponent();
        }

        private void KullaniciBilgileri_Load(object sender, EventArgs e)
        {
            if (LoginCalisan.calisan != null)
            {
                lbl_isim.Text = "İsim: " + LoginCalisan.calisan.Isim;
                lbl_soyisim.Text = "Soyisim: " + LoginCalisan.calisan.Soyisim;
                lbl_mail.Text = "Mail: " + LoginCalisan.calisan.Mail;
                lbl_sifre.Text = "Şifre: " + LoginCalisan.calisan.Sifre;
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

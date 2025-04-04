using BeylinaWinApp.Çalışan_Paneli;
using BeylinaWinApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeylinaWinApp.Üye_Paneli
{
    public partial class KullaniciBilgileriUye : Form
    {
        public KullaniciBilgileriUye()
        {
            InitializeComponent();
        }

        private void KullaniciBilgileriUye_Load(object sender, EventArgs e)
        {
            // Giriş yapan kullanıcının bilgilerini kontrol et
            if (LoginUser.user != null)
            {
                // Sadece isim ve soyisim göstereceğiz
                lbl_isim.Text = "İsim: " + LoginUser.user.Isim;
                lbl_soyisim.Text = "Soyisim: " + LoginUser.user.Soyisim;

                // Mail, şifre ve kart no'yu göstermiyoruz
                lbl_mail.Text = "Mail: ***";   // Gizli tutmak için yerine *** yazdık
                lbl_sifre.Text = "Şifre: ***"; // Gizli tutmak için yerine *** yazdık
                lbl_kartNo.Text = "Kart No: ***";  // Gizli tutmak için yerine *** yazdık
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AktarKullaniciBilgileri(User u)
        {
            // Kullanıcı bilgilerini Label'lara aktar
            lbl_isim.Text = "İsim: " + u.Isim;
            lbl_soyisim.Text = "Soyisim: " + u.Soyisim;

            // Mail, şifre ve kart numarasını gizle
            lbl_mail.Text = "Mail: ***";  // Gizli tutmak için yerine *** yazdık
            lbl_sifre.Text = "Şifre: ***"; // Gizli tutmak için yerine *** yazdık
            lbl_kartNo.Text = "Kart No: ***";  // Gizli tutmak için yerine *** yazdık
        }

        private void btn_hesapSil_Click(object sender, EventArgs e)
        {
            UyeHesapSil hesapSilFormu = new UyeHesapSil();
            hesapSilFormu.Show();
        }

    }
}

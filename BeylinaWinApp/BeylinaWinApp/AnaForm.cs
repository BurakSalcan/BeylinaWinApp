using BeylinaWinApp.Çalışan_Paneli.Kategori_İşlemleri;
using BeylinaWinApp.Çalışan_Paneli.Kayıtlı_Kullanıcı_İşlemleri;
using BeylinaWinApp.Giriş;
using BeylinaWinApp.Model;
using BeylinaWinApp.Üye_Paneli;
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
            MessageBox.Show("Üye Formu Açıldı");

            this.IsMdiContainer = true;
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
            }

            toolStripStatusLabel1.Text = "Giriş Yapan Üye: " + LoginUser.user.Isim + " " + LoginUser.user.Soyisim;
            lbl_kullanici.Text = LoginUser.user.Isim + " " + LoginUser.user.Soyisim;
        }


        private void TSMI_magaza_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Magaza))
                {
                    acikMi = true;
                    form.Activate();
                }
            }

            if (!acikMi)
            {
                Magaza frm = new Magaza();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;

                frm.FormClosed += (s, args) =>
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lbl_kullanici.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                };

                frm.Show();
            }

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lbl_kullanici.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }


        private void TSMI_kullaniciBilgileri_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(KullaniciBilgileriUye))
                {
                    acikMi = true;
                    form.Activate();
                }
            }

            if (!acikMi)
            {
                KullaniciBilgileriUye frm = new KullaniciBilgileriUye();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;

                frm.FormClosed += (s, args) =>
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lbl_kullanici.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                };

                frm.Show();
            }

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lbl_kullanici.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        
    }
}

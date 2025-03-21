using BeylinaWinApp.Çalışan_Paneli;
using BeylinaWinApp.Çalışan_Paneli.Kategori_İşlemleri;
using BeylinaWinApp.Çalışan_Paneli.Kayıtlı_Kullanıcı_İşlemleri;
using BeylinaWinApp.Çalışan_Paneli.Ürün_İşlemleri;
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

namespace BeylinaWinApp
{
    public partial class CalisanForm : Form
    {
        public CalisanForm()
        {
            InitializeComponent();
            MessageBox.Show("Çalışan Formu Açıldı.");

            this.IsMdiContainer = true;
        }

        private void CalisanForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Giriş Yapan Çalışan: " + LoginCalisan.calisan.TamIsim;

            UrunSayisiniGuncelle();
            KategoriSayisiniGuncelle();
            AltKategoriSayisiniGuncelle();
            CalisanSayisiniGuncelle();
            UyeSayisiniGuncelle();
        }
        
        private void TSMI_Kategoriler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Kategoriler))
                {
                    acikMi = true;
                    form.Activate();
                }
            }

            if (!acikMi)
            {
                Kategoriler frm = new Kategoriler();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;

                frm.FormClosed += (s, args) =>
                {
                    lbl_urunSayisi.Visible = true;
                    lbl_kategoriSayisi.Visible = true;
                    lbl_altKategoriSayisi.Visible = true;
                    lbl_calisanSayisi.Visible = true;
                    lbl_uyeSayisi.Visible = true;
                };

                frm.Show();
            }

            lbl_urunSayisi.Visible = false;
            lbl_kategoriSayisi.Visible = false;
            lbl_altKategoriSayisi.Visible = false;
            lbl_calisanSayisi.Visible = false;
            lbl_uyeSayisi.Visible = false;
        }

        private void TSMI_Calisanlar_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Calisanlar))
                {
                    acikMi = true;
                    form.Activate();
                }
            }

            if (!acikMi)
            {
                Calisanlar frm = new Calisanlar();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;

                frm.FormClosed += (s, args) =>
                {
                    lbl_urunSayisi.Visible = true;
                    lbl_kategoriSayisi.Visible = true;
                    lbl_altKategoriSayisi.Visible = true;
                    lbl_calisanSayisi.Visible = true;
                    lbl_uyeSayisi.Visible = true;
                };

                frm.Show();
            }

            lbl_urunSayisi.Visible = false;
            lbl_kategoriSayisi.Visible = false;
            lbl_altKategoriSayisi.Visible = false;
            lbl_calisanSayisi.Visible = false;
            lbl_uyeSayisi.Visible = false;
        }

        private void TSMI_Uyeler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Uyeler))
                {
                    acikMi = true;
                    form.Activate();
                }
            }

            if (!acikMi)
            {
                Uyeler frm = new Uyeler();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;

                frm.FormClosed += (s, args) =>
                {
                    lbl_urunSayisi.Visible = true;
                    lbl_kategoriSayisi.Visible = true;
                    lbl_altKategoriSayisi.Visible = true;
                    lbl_calisanSayisi.Visible = true;
                    lbl_uyeSayisi.Visible = true;
                };

                frm.Show();
            }

            lbl_urunSayisi.Visible = false;
            lbl_kategoriSayisi.Visible = false;
            lbl_altKategoriSayisi.Visible = false;
            lbl_calisanSayisi.Visible = false;
            lbl_uyeSayisi.Visible = false;
        }

        private void TSMI_Urunler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Urunler))
                {
                    acikMi = true;
                    form.Activate();
                }
            }

            if (!acikMi)
            {
                Urunler frm = new Urunler();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;

                frm.FormClosed += (s, args) =>
                {
                    lbl_urunSayisi.Visible = true;
                    lbl_kategoriSayisi.Visible = true;
                    lbl_altKategoriSayisi.Visible = true;
                    lbl_calisanSayisi.Visible = true;
                    lbl_uyeSayisi.Visible = true;
                };

                frm.Show();
            }

            lbl_urunSayisi.Visible = false;
            lbl_kategoriSayisi.Visible = false;
            lbl_altKategoriSayisi.Visible = false;
            lbl_calisanSayisi.Visible = false;
            lbl_uyeSayisi.Visible = false;
        }

        private void TSMI_KullaniciBilgileri_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(KullaniciBilgileri))
                {
                    acikMi = true;
                    form.Activate();
                }
            }

            if (!acikMi)
            {
                KullaniciBilgileri frm = new KullaniciBilgileri();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;

                frm.FormClosed += (s, args) =>
                {
                    lbl_urunSayisi.Visible = true;
                    lbl_kategoriSayisi.Visible = true;
                    lbl_altKategoriSayisi.Visible = true;
                    lbl_calisanSayisi.Visible = true;
                    lbl_uyeSayisi.Visible = true;
                };

                frm.Show();
            }

            lbl_urunSayisi.Visible = false;
            lbl_kategoriSayisi.Visible = false;
            lbl_altKategoriSayisi.Visible = false;
            lbl_calisanSayisi.Visible = false;
            lbl_uyeSayisi.Visible = false;
        }

        #region Veri Sayısı Getirme Metotları
        private void UrunSayisiniGuncelle()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Urunler", con))
                    {
                        int urunSayisi = (int)cmd.ExecuteScalar();
                        lbl_urunSayisi.Text = $"Toplam Ürün Sayısı: {urunSayisi}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void KategoriSayisiniGuncelle()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Kategori", con))
                    {
                        int kategoriSayisi = (int)cmd.ExecuteScalar();
                        lbl_kategoriSayisi.Text = $"Toplam Kategori Sayısı: {kategoriSayisi}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AltKategoriSayisiniGuncelle()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Alt_Kategori", con))
                    {
                        int altKategoriSayisi = (int)cmd.ExecuteScalar();
                        lbl_altKategoriSayisi.Text = $"Toplam Alt Kategori Sayısı: {altKategoriSayisi}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CalisanSayisiniGuncelle()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Calisan", con))
                    {
                        int calisanSayisi = (int)cmd.ExecuteScalar();
                        lbl_calisanSayisi.Text = $"Toplam Çalışan Sayısı: {calisanSayisi}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UyeSayisiniGuncelle()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Uye", con))
                    {
                        int uyeSayisi = (int)cmd.ExecuteScalar();
                        lbl_uyeSayisi.Text = $"Toplam Üye Sayısı: {uyeSayisi}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

    }
}

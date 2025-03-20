using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeylinaWinApp.Giriş.Çalışan
{
    public partial class CalisanKayit : Form
    {
        public CalisanKayit()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            string isim = tb_isim.Text.Trim();
            string soyisim = tb_soyisim.Text.Trim();
            string mail = tb_mail.Text.Trim();
            string sifre = tb_sifre.Text.Trim();

            // ✅ Boş alan kontrolü
            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) ||
                string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("İsim, Soyisim, Mail ve Şifre alanları boş bırakılamaz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ E-posta formatı kontrolü (@ ve . içermeli)
            if (!Regex.IsMatch(mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin! (örn: dev@dev.com)",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Veritabanına kayıt ekleme
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=true"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Calisan (Isim, Soyisim, Mail, Sifre) VALUES (@isim, @soyisim, @mail, @sifre)", conn);
                    cmd.Parameters.AddWithValue("@isim", isim);
                    cmd.Parameters.AddWithValue("@soyisim", soyisim);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    int result = cmd.ExecuteNonQuery(); // Kayıt ekleme başarılı mı?

                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt işleminiz başarıyla gerçekleşti!",
                                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CalisanGiris girisFormu = new CalisanGiris();
                        this.Hide();
                        girisFormu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız! Lütfen tekrar deneyin.",
                                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

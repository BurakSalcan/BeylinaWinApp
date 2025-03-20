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

namespace BeylinaWinApp.Giriş.Üye
{
    public partial class UyeKayit : Form
    {
        public UyeKayit()
        {
            InitializeComponent();
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            // 1️⃣ GİRİLEN BİLGİLERİ KONTROL ET
            if (string.IsNullOrWhiteSpace(tb_isim.Text) ||
                string.IsNullOrWhiteSpace(tb_soyisim.Text) ||
                string.IsNullOrWhiteSpace(tb_mail.Text) ||
                string.IsNullOrWhiteSpace(tb_sifre.Text) ||
                string.IsNullOrWhiteSpace(mtb_kartNo.Text.Replace("-", "").Trim()))
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ KART NUMARASI DOĞRULAMA (16 Haneli mi?)
            if (mtb_kartNo.Text.Replace("-", "").Length != 16)
            {
                MessageBox.Show("Kart numarası eksik veya hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3️⃣ E-POSTA FORMAT DOĞRULAMA
            if (!Regex.IsMatch(tb_mail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz! (Örn: example@mail.com)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4️⃣ VERİTABANINA KAYDET
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=true"))
                {
                    conn.Open();
                    string query = "INSERT INTO Uye (Isim, Soyisim, Mail, Sifre, KartNo) VALUES (@isim, @soyisim, @mail, @sifre, @kartNo)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@isim", tb_isim.Text);
                        cmd.Parameters.AddWithValue("@soyisim", tb_soyisim.Text);
                        cmd.Parameters.AddWithValue("@mail", tb_mail.Text);
                        cmd.Parameters.AddWithValue("@sifre", tb_sifre.Text);
                        cmd.Parameters.AddWithValue("@kartNo", mtb_kartNo.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt işlemi başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 5️⃣ ÜYE GİRİŞ FORMUNU AÇ VE BU FORMU KAPAT
                            this.Hide();
                            UyeGiris uyeGirisForm = new UyeGiris();
                            uyeGirisForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt sırasında bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

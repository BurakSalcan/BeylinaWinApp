using BeylinaWinApp.Giriş;
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

namespace BeylinaWinApp.Çalışan_Paneli
{
    public partial class CalisanHesapSil : Form
    {
        public CalisanHesapSil()
        {
            InitializeComponent();
        }

        private void btn_evet_Click(object sender, EventArgs e)
        {
            if (LoginCalisan.calisan != null)
            {
                int calisanID = LoginCalisan.calisan.ID;

                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=true"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Calisan WHERE ID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", calisanID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hesabınız başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Kullanıcı oturumunu sıfırla
                            LoginCalisan.calisan = null;

                            // Açık olan formları kapatmak yerine gizle
                            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
                            {
                                form.Hide();
                            }

                            // 📌 GirisSecim formunu aç
                            GirisSecim girisSecim = new GirisSecim();
                            girisSecim.ShowDialog(); // Show yerine ShowDialog kullanarak kapanmasını önle
                        }
                        else
                        {
                            MessageBox.Show("Hesap silinemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_hayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

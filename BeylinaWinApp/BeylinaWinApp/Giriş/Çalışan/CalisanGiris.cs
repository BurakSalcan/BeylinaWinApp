using BeylinaWinApp.Giriş.Çalışan;
using BeylinaWinApp.Giriş.Üye;
using BeylinaWinApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeylinaWinApp.Giriş
{
    public partial class CalisanGiris : Form
    {
        bool islogin = false;
        public CalisanGiris()
        {
            InitializeComponent();
        }

        private void btn_calisanGiris_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_mail.Text) && !String.IsNullOrEmpty(tb_sifre.Text))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=true"))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT ID, Isim, Soyisim, Isim+' '+Soyisim FROM Calisan WHERE Mail=@ma AND Sifre=@pss";
                    cmd.Parameters.AddWithValue("@ma", tb_mail.Text);
                    cmd.Parameters.AddWithValue("@pss", tb_sifre.Text);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Calisan c = null;
                    while (reader.Read())
                    {
                        c = new Calisan();
                        c.ID = reader.GetInt32(0);
                        c.Isim = reader.GetString(1);
                        c.Soyisim = reader.GetString(2);
                        c.TamIsim = reader.GetString(3);
                        //c.Mail = reader.GetString(4); 
                        //c.Sifre = reader.GetString(5); 
                    }
                    if (c != null)
                    {
                        LoginCalisan.calisan = c;
                        islogin = true;
                        CalisanForm calisanForm = new CalisanForm();

                        // Açık olan tüm Calisan formlarını kapat
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form is CalisanGiris)
                            {
                                form.Hide();
                                form.Close();
                                break; // İlk bulduğunu kapattıktan sonra döngüden çık
                            }
                        }

                        calisanForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_calisanKayit_Click(object sender, EventArgs e)
        {
            CalisanKayit calisanKyt = new CalisanKayit();
            this.Hide();
            calisanKyt.ShowDialog();
            this.Close();
        }
    }
}

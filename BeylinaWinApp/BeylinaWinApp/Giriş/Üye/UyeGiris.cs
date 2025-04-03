using BeylinaWinApp.Giriş.Üye;
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

namespace BeylinaWinApp.Giriş
{
    public partial class UyeGiris : Form
    {
        bool islogin = false;

        public UyeGiris()
        {
            InitializeComponent();
        }

        private void btn_uyeGiris_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_mail.Text) && !String.IsNullOrEmpty(tb_sifre.Text))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=true"))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT ID, Isim, Soyisim, Isim+' '+Soyisim FROM Uye WHERE Mail=@ma AND Sifre=@pss";
                    cmd.Parameters.AddWithValue("@ma", tb_mail.Text);
                    cmd.Parameters.AddWithValue("@pss", tb_sifre.Text);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    User u = null;
                    while (reader.Read())
                    {
                        u = new User();
                        u.ID = reader.GetInt32(0);
                        u.Isim = reader.GetString(1);
                        u.Soyisim = reader.GetString(2);
                        u.TamIsim = reader.GetString(3);
                    }
                    if (u != null)
                    {
                        LoginUser.user = u;
                        islogin = true;
                        AnaForm anaForm = new AnaForm();

                        // Açık olan tüm UyeGiris formlarını kapat
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form is UyeGiris)
                            {
                                form.Hide();
                                form.Close();
                                break; // İlk bulduğunu kapattıktan sonra döngüden çık
                            }
                        }

                        anaForm.ShowDialog();
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

        private void btn_uyeKayit_Click(object sender, EventArgs e)
        {
            UyeKayit uyeKyt = new UyeKayit();
            this.Hide();
            uyeKyt.ShowDialog();
            this.Close();
        }
    }
}

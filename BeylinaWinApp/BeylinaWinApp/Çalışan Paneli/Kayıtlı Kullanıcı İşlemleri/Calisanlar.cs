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

namespace BeylinaWinApp.Çalışan_Paneli.Kayıtlı_Kullanıcı_İşlemleri
{
    public partial class Calisanlar : Form
    {
        public Calisanlar()
        {
            InitializeComponent();
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {
            CalisanGetir();
        }

        private void CalisanGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT C.ID, C.Isim, C.Soyisim, C.Mail FROM Calisan as C";
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Çalışan No");
                dt.Columns.Add("Çalışanın İsmi");
                dt.Columns.Add("Çalışanın Soyismi");
                dt.Columns.Add("Çalışanın Mail Adresi");
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string isim = reader.GetString(1);
                    string soyisim = reader.GetString(2);
                    string mail = reader.GetString(3);

                    dt.Rows.Add(id, isim, soyisim, mail);
                }
                DGV_calisan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

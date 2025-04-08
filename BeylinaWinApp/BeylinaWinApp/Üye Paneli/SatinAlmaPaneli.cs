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
    public partial class SatinAlmaPaneli : Form
    {
        int selectedProductID;
        int selectedProductStock;
        string selectedProductName;
        string ad = LoginUser.user.Isim;
        string soyad = LoginUser.user.Soyisim;
        public SatinAlmaPaneli(int urunID, int urunStok, string urunAdi)
        {
            InitializeComponent();

            selectedProductID = urunID;
            selectedProductStock = urunStok;
            selectedProductName = urunAdi;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_satinAl_Click(object sender, EventArgs e)
        {
            string girilenKart = mtb_kartNo.Text.Trim();

            if (string.IsNullOrEmpty(girilenKart))
            {
                MessageBox.Show("Lütfen kart bilgilerini eksiksiz giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (girilenKart != LoginUser.user.KartNo)
            {
                MessageBox.Show("Kart bilgisi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kart doğruysa: stok düşür ve başarılı mesaj ver
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=true"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Urunler SET Stok = Stok - 1 WHERE ID = @id", con);
                    cmd.Parameters.AddWithValue("@id", selectedProductID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Sayın {ad} {soyad}, '{selectedProductName}' isimli ürün başarıyla satın alınmıştır.",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Satın alma işlemi sırasında hata oluştu: " + ex.Message);
                }
            }
        }
    }
}

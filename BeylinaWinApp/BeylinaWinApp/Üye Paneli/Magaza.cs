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
    public partial class Magaza : Form
    {
        public Magaza()
        {
            InitializeComponent();
        }

        private void Magaza_Load(object sender, EventArgs e)
        {
            KategorileriYukle();

            cb_kategoriler.SelectedIndexChanged += cb_kategoriler_SelectedIndexChanged;
        }

        #region Combo Box Kategoriler

        private void KategorileriYukle()
        {
            cb_kategoriler.Items.Clear(); // Önce temizleyelim
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT ID, Isim FROM Kategori";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        Dictionary<int, string> kategoriListesi = new Dictionary<int, string>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string isim = reader.GetString(1);
                            kategoriListesi.Add(id, isim);
                        }

                        cb_kategoriler.DataSource = new BindingSource(kategoriListesi, null);
                        cb_kategoriler.DisplayMember = "Value"; // Kullanıcıya gösterilecek değer
                        cb_kategoriler.ValueMember = "Key"; // Seçildiğinde alınacak değer (ID)
                        cb_kategoriler.SelectedIndex = -1; // Varsayılan olarak seçili olmasın
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategoriler yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void AltKategorileriYukle(int kategoriID)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT ID, Isim FROM Alt_Kategori WHERE Kategori_ID = @KategoriID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@KategoriID", kategoriID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        Dictionary<int, string> altKategoriListesi = new Dictionary<int, string>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string isim = reader.GetString(1);
                            altKategoriListesi.Add(id, isim);
                        }

                        cb_altKategoriler.DataSource = new BindingSource(altKategoriListesi, null);
                        cb_altKategoriler.DisplayMember = "Value";
                        cb_altKategoriler.ValueMember = "Key";
                        cb_altKategoriler.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Alt kategoriler yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }


        private void cb_kategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_kategoriler.SelectedItem != null)
            {
                var secilenKategori = (KeyValuePair<int, string>)cb_kategoriler.SelectedItem;
                int kategoriID = secilenKategori.Key;

                AltKategorileriYukle(kategoriID); // Seçilen kategoriye göre alt kategorileri getir
            }
        }


        #endregion

        private void cb_altKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kategori ve alt kategori seçildiğinde, ürünleri listele
            if (cb_kategoriler.SelectedIndex != -1 && cb_altKategoriler.SelectedIndex != -1)
            {
                UrunleriListele(); // Ürünleri listele
            }
        }

        private void UrunleriListele()
        {
            // DataGridView sütunlarını oluştur
            dgv_urunler.Columns.Clear(); // Önce eski sütunları temizle

            // Sütunları ekleyelim
            dgv_urunler.Columns.Add("UrunIsim", "Ürün Adı");
            dgv_urunler.Columns.Add("UrunGorseli", "Ürün Görseli");
            dgv_urunler.Columns.Add("Marka", "Marka");
            dgv_urunler.Columns.Add("Aciklama", "Açıklama");
            dgv_urunler.Columns.Add("Fiyat", "Fiyat");
            dgv_urunler.Columns.Add("Stok", "Stok");

            // DataGridView'i temizle
            dgv_urunler.Rows.Clear();

            int kategoriID = (int)((KeyValuePair<int, string>)cb_kategoriler.SelectedItem).Key;
            int altKategoriID = (int)((KeyValuePair<int, string>)cb_altKategoriler.SelectedItem).Key;

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Isim, UrunGorseli, Marka, Aciklama, Fiyat, Stok FROM Urunler " +
                                   "WHERE Kategori_ID = @KategoriID AND AltKategori_ID = @AltKategoriID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@KategoriID", kategoriID);
                        cmd.Parameters.AddWithValue("@AltKategoriID", altKategoriID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // DataGridView'e ürün ekle
                            dgv_urunler.Rows.Add(
                                reader["Isim"].ToString(),
                                reader["UrunGorseli"].ToString(), // Görsel yolu, uygun şekilde gösterilebilir.
                                reader["Marka"].ToString(),
                                reader["Aciklama"].ToString(),
                                reader["Fiyat"].ToString(),
                                reader["Stok"].ToString()
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürünler yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

    }
}

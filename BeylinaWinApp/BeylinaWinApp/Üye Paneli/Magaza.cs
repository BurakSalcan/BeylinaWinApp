using BeylinaWinApp.Çalışan_Paneli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeylinaWinApp.Üye_Paneli
{
    public partial class Magaza : Form
    {
        //int urunID;
        //int urunStok;

        public Magaza()
        {
            InitializeComponent();

            //this.urunID = urunID;
            //this.urunStok = urunStok;
        }

        private void Magaza_Load(object sender, EventArgs e)
        {
            // Sadece bir kere sütunları ekle
            if (dgv_urunler.Columns.Count == 0)
            {
                dgv_urunler.Columns.Add("UrunIsim", "Ürün Adı");
                dgv_urunler.Columns.Add("UrunGorseli", "Ürün Görseli");
                dgv_urunler.Columns.Add("Marka", "Marka");
                dgv_urunler.Columns.Add("Aciklama", "Açıklama");
                dgv_urunler.Columns.Add("Fiyat", "Fiyat");
                dgv_urunler.Columns.Add("Stok", "Stok");
            }

            // Satır seçimi değiştiğinde görseli göster
            dgv_urunler.CellClick += dgv_urunler_CellClick;

            cb_kategoriler.SelectedIndexChanged += cb_kategoriler_SelectedIndexChanged;

            // Kategorileri yükle
            KategorileriYukle();
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
            dgv_urunler.Columns.Clear(); // Sütunları temizle

            // 🔑 ID sütununu ekle ama görünmez yap
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "UrunID";
            idColumn.HeaderText = "ID";
            idColumn.Visible = false; // Kullanıcı görmesin
            dgv_urunler.Columns.Add(idColumn);

            dgv_urunler.Columns.Add("UrunIsim", "Ürün Adı");
            dgv_urunler.Columns.Add("UrunGorseli", "Ürün Görseli");
            dgv_urunler.Columns.Add("Marka", "Marka");
            dgv_urunler.Columns.Add("Aciklama", "Açıklama");
            dgv_urunler.Columns.Add("Fiyat", "Fiyat");
            dgv_urunler.Columns.Add("Stok", "Stok");

            dgv_urunler.Rows.Clear(); // Önceki satırları sil

            int kategoriID = (int)((KeyValuePair<int, string>)cb_kategoriler.SelectedItem).Key;
            int altKategoriID = (int)((KeyValuePair<int, string>)cb_altKategoriler.SelectedItem).Key;

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT ID, Isim, UrunGorseli, Marka, Aciklama, Fiyat, Stok FROM Urunler " +
                                   "WHERE Kategori_ID = @KategoriID AND AltKategori_ID = @AltKategoriID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@KategoriID", kategoriID);
                        cmd.Parameters.AddWithValue("@AltKategoriID", altKategoriID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            dgv_urunler.Rows.Add(
                                reader["ID"].ToString(),
                                reader["Isim"].ToString(),
                                reader["UrunGorseli"].ToString(),
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


        private void dgv_urunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer geçerli satırda bir ürün seçilmişse
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki ürün bilgilerini al
                string urunAdi = dgv_urunler.Rows[e.RowIndex].Cells["UrunIsim"].Value.ToString();
                string marka = dgv_urunler.Rows[e.RowIndex].Cells["Marka"].Value.ToString();
                string aciklama = dgv_urunler.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
                string fiyat = dgv_urunler.Rows[e.RowIndex].Cells["Fiyat"].Value.ToString();
                string stok = dgv_urunler.Rows[e.RowIndex].Cells["Stok"].Value.ToString();
                string urunGorseli = dgv_urunler.Rows[e.RowIndex].Cells["UrunGorseli"].Value.ToString();

                // Bilgileri label'lara aktar
                lbl_urunAdi.Text = urunAdi;
                lbl_marka.Text = marka;
                lbl_aciklama.Text = aciklama;
                lbl_fiyat.Text = fiyat + " ₺";
                lbl_stok.Text = stok + " adet";

                // Görseli göster
                if (!string.IsNullOrEmpty(urunGorseli))
                {
                    string dosyaAdi = urunGorseli;
                    string tamYol = Path.Combine(@"C:\Gorseller", dosyaAdi); // Görsel yolunu oluştur

                    if (File.Exists(tamYol))  // Eğer görsel varsa
                    {
                        pb_urunler.Image = Image.FromFile(tamYol);  // Görseli göster
                    }
                    else
                    {
                        pb_urunler.Image = null;  // Görsel bulunamadıysa boş bırak
                        MessageBox.Show("Görsel bulunamadı: " + tamYol);
                    }
                }
            }
        }

        private void btn_satinAlMagaza_Click(object sender, EventArgs e)
        {
            if (dgv_urunler.CurrentRow != null)
            {
                int urunID = Convert.ToInt32(dgv_urunler.CurrentRow.Cells["UrunID"].Value);
                int urunStok = Convert.ToInt32(dgv_urunler.CurrentRow.Cells["Stok"].Value);
                string urunAdi = dgv_urunler.CurrentRow.Cells["UrunIsim"].Value.ToString();

                // SatinAlmaPaneli formunu gerekli bilgilerle başlat
                SatinAlmaPaneli satinAlmaForm = new SatinAlmaPaneli(urunID, urunStok, urunAdi);
                satinAlmaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
            }
        }
    }
}

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

namespace BeylinaWinApp.Çalışan_Paneli.Ürün_İşlemleri
{
    public partial class Urunler : Form
    {
        private int selectedProductID;
        public Urunler()
        {
            InitializeComponent();
            UrunleriGetir();

            // ContextMenuStrip tıklama olayını buraya ekliyoruz
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            // Kategori ComboBox'ını doldur
            string kategoriQuery = "SELECT ID, Isim FROM Kategori WHERE AktifMi = 1";
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(kategoriQuery, connection);
                DataTable kategoriTable = new DataTable();
                dataAdapter.Fill(kategoriTable);

                cb_kategori.DataSource = kategoriTable;
                cb_kategori.DisplayMember = "Isim";
                cb_kategori.ValueMember = "ID";
            }

            // Alt Kategori ComboBox'ı için başlangıçta boş bir seçim yapılması sağlanabilir
            cb_altKategori.DataSource = null;

            // DataGridView'de çift tıklama olayını bağla
            DGV_urunler.MouseDoubleClick += DGV_urunler_MouseDoubleClick;
        }

        private void btn_görsel_Click(object sender, EventArgs e)
        {
            // Kullanıcının yalnızca resim dosyalarını seçmesini sağla
            openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Eğer kullanıcı bir dosya seçip "Tamam" derse
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog1.FileName; // Seçilen dosyanın yolu
                pb_urunGorsel.Image = Image.FromFile(dosyaYolu); // PictureBox'a resmi yükle
            }
        }

        private void UrunleriGetir()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                string query = @"
            SELECT 
                U.ID AS 'ID',
                U.Isim AS 'Ürün İsmi',
                K.Isim AS 'Kategori',  
                AK.Isim AS 'Alt Kategori',  
                U.UrunGorseli AS 'Ürün Görseli',
                U.Marka AS 'Marka',
                U.Aciklama AS 'Açıklama',
                U.Fiyat AS 'Fiyat',
                U.Stok AS 'Stok'
            FROM Urunler U
            INNER JOIN Kategori K ON U.Kategori_ID = K.ID
            INNER JOIN Alt_Kategori AK ON U.AltKategori_ID = AK.ID;";

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // SQL verisini DataTable'a doldur

                    DGV_urunler.DataSource = dt; // DataGridView'e ata
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantı cümlesi
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True";

            // Formdaki kontrol değerlerini al
            string isim = tb_isim.Text;
            int kategoriID = Convert.ToInt32(cb_kategori.SelectedValue);
            int altKategoriID = Convert.ToInt32(cb_altKategori.SelectedValue);
            string marka = tb_marka.Text;
            string aciklama = tb_aciklama.Text;
            decimal fiyat = nud_fiyat.Value;
            int stok = (int)nud_stok.Value;

            // Alanları kontrol et
            if (string.IsNullOrEmpty(isim) || kategoriID == 0 || altKategoriID == 0 || string.IsNullOrEmpty(marka) || string.IsNullOrEmpty(aciklama) || fiyat <= 0 || stok <= 0)
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun!", "Eksik Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kaydetme işlemi yapılmaz, fonksiyon sonlanır
            }

            // Görseli kaydet
            string urunGorselDosyaYolu = null;
            if (pb_urunGorsel.Image != null)
            {
                // Görseli bir dosyaya kaydet
                string dosyaAdi = Guid.NewGuid().ToString() + ".jpg"; // Görseli benzersiz bir isimle kaydediyoruz
                string dosyaYolu = Path.Combine("C:\\Gorseller", dosyaAdi); // Görsel dosyasının kaydedileceği yol (C:\\Gorseller dizininde)

                pb_urunGorsel.Image.Save(dosyaYolu); // Görseli kaydet
                urunGorselDosyaYolu = dosyaYolu; // Görselin yolunu sakla
            }

            // SQL Insert komutunu oluştur
            string query = "INSERT INTO Urunler (Isim, Kategori_ID, AltKategori_ID, UrunGorseli, Marka, Aciklama, Fiyat, Stok) " +
                           "VALUES (@Isim, @Kategori_ID, @AltKategori_ID, @UrunGorseli, @Marka, @Aciklama, @Fiyat, @Stok)";

            // Veritabanı işlemi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Parametreleri ekle
                command.Parameters.AddWithValue("@Isim", isim);
                command.Parameters.AddWithValue("@Kategori_ID", kategoriID);
                command.Parameters.AddWithValue("@AltKategori_ID", altKategoriID);
                command.Parameters.AddWithValue("@UrunGorseli", urunGorselDosyaYolu ?? (object)DBNull.Value); // Eğer görsel yoksa NULL gönder
                command.Parameters.AddWithValue("@Marka", string.IsNullOrEmpty(marka) ? (object)DBNull.Value : marka);
                command.Parameters.AddWithValue("@Aciklama", string.IsNullOrEmpty(aciklama) ? (object)DBNull.Value : aciklama);
                command.Parameters.AddWithValue("@Fiyat", fiyat);
                command.Parameters.AddWithValue("@Stok", stok);

                // Bağlantıyı aç ve komutu çalıştır
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarıyla kaydedildi.");

                    // Ürün ekle işleminden sonra grid view'ı yenile
                    GridViewYenile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void cb_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eğer bir öğe seçildiyse
            if (cb_kategori.SelectedValue != null)
            {
                try
                {
                    // Seçilen öğe DataRowView olduğunda, Value'yu düzgün almak için.
                    var selectedItem = cb_kategori.SelectedItem as DataRowView;

                    if (selectedItem != null)
                    {
                        // KategoriID'yi al
                        int kategoriID = Convert.ToInt32(selectedItem["ID"]);

                        // Alt Kategori ComboBox'ını doldur
                        string altKategoriQuery = "SELECT ID, Isim FROM Alt_Kategori WHERE Kategori_ID = @KategoriID";

                        using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
                        {
                            SqlCommand command = new SqlCommand(altKategoriQuery, connection);
                            command.Parameters.AddWithValue("@KategoriID", kategoriID);

                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                            DataTable altKategoriTable = new DataTable();
                            dataAdapter.Fill(altKategoriTable);

                            // Alt Kategori ComboBox'ına veriyi yükle
                            cb_altKategori.DataSource = altKategoriTable;
                            cb_altKategori.DisplayMember = "Isim";  // Alt Kategori ismini gösterecek
                            cb_altKategori.ValueMember = "ID";      // Alt Kategori ID'sini değeri olarak kullanacak
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void GridViewYenile()
        {
            try
            {
                string selectQuery = "SELECT ID, Isim, Kategori_ID, AltKategori_ID, Marka, Fiyat, Stok, Aciklama FROM Urunler";

                using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    DGV_urunler.DataSource = dataTable; // DGV_urunler'ın DataSource'unu güncelle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductID == 0)
                {
                    MessageBox.Show("Silinecek ürün seçilmedi.");
                    return;
                }

                // Seçili ürünü veritabanından sil
                using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Urunler WHERE ID = @UrunID";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@UrunID", selectedProductID);

                    // Komutu çalıştır
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // Başarılı ise, DataGridView'i yenile
                        MessageBox.Show("Ürün başarıyla silindi.");
                        GridViewYenile(); // DataGridView'i güncelleyen metot
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız.");
                    }

                    // Silme işleminden sonra ID'yi sıfırlayın
                    selectedProductID = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void DGV_urunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Çift tıklama olayında, tıklanan hücrenin indeksini al
            DataGridView.HitTestInfo hit = DGV_urunler.HitTest(e.X, e.Y);

            // Tıklanan satır indeksini kontrol et
            if (hit.RowIndex >= 0)
            {
                // Seçilen satırı al
                DataGridViewRow selectedRow = DGV_urunler.Rows[hit.RowIndex];

                // Seçilen ürünün ID'sini al
                selectedProductID = (int)selectedRow.Cells["ID"].Value; // "Ürün No" yerine "ID" kullan

                // ContextMenuStrip'i aç
                contextMenuStrip1.Show(DGV_urunler, new Point(e.X, e.Y));
            }
        }
    }
}

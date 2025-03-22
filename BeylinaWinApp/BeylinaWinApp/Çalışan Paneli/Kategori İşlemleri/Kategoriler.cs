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

namespace BeylinaWinApp.Çalışan_Paneli.Kategori_İşlemleri
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            KategoriGetir();
            AltKategoriGetir();
            KategorileriYukle();

        }

        #region Grid View Metotları

        private void KategoriGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT K.ID, K.Isim, K.Aciklama, K.AktifMi FROM Kategori as K";
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("No");
                dt.Columns.Add("Kategori İsmi");
                dt.Columns.Add("Açıklama");
                dt.Columns.Add("Durum"); // "Aktif mi" yerine anlamlı bir isim

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string isim = reader.GetString(1);
                    string aciklama = reader.GetString(2);
                    bool aktifMi = reader.GetBoolean(3);

                    // True -> "Aktif", False -> "Aktif Değil"
                    string aktifDurumu = aktifMi ? "Aktif" : "Aktif Değil";

                    dt.Rows.Add(id, isim, aciklama, aktifDurumu);
                }
                DGV_kategoriler.DataSource = dt;
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

        private void AltKategoriGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT AK.ID, AK.Isim AS 'Alt Kategori İsmi', K.Isim AS 'Kategori İsmi' " +
                              "FROM Alt_Kategori AS AK " +
                              "INNER JOIN Kategori AS K ON AK.Kategori_ID = K.ID";

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("No");
                dt.Columns.Add("Alt Kategori İsmi");
                dt.Columns.Add("Kategori İsmi"); // Kategori ID yerine kategori adı gösterilecek

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string altKategoriIsmi = reader.GetString(1);
                    string kategoriIsmi = reader.GetString(2); // Kategori ismini alıyoruz

                    dt.Rows.Add(id, altKategoriIsmi, kategoriIsmi);
                }
                DGV_altKategoriler.DataSource = dt;
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


        #endregion

        private void btn_kategoriOlustur_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan veriler
            string kategoriAdi = tb_kategoriAdi.Text.Trim();
            string aciklama = tb_aciklama.Text.Trim();
            bool aktifMi = cb_AktifMi.Checked;

            // Eğer kategori adı boşsa işlemi durdur
            if (string.IsNullOrEmpty(kategoriAdi))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL bağlantısı oluştur
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Kategori (Isim, Aciklama, AktifMi) VALUES (@isim, @aciklama, @aktifMi)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@isim", kategoriAdi);
                        cmd.Parameters.AddWithValue("@aciklama", aciklama);
                        cmd.Parameters.AddWithValue("@aktifMi", aktifMi);

                        int result = cmd.ExecuteNonQuery(); // Komutu çalıştır

                        if (result > 0)
                        {
                            MessageBox.Show("Kategori başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ✅ GridView'i Güncelle
                            KategoriGetir();

                            // ✅ Form elemanlarını temizle
                            tb_kategoriAdi.Text = "";
                            tb_aciklama.Text = "";
                            cb_AktifMi.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Kategori eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_altKategoriOlustur_Click(object sender, EventArgs e)
        {
            // 📌 1️⃣ Kullanıcıdan alınan veriler
            string altKategoriAdi = tb_altKategoriAdi.Text.Trim();
            if (string.IsNullOrEmpty(altKategoriAdi))
            {
                MessageBox.Show("Alt kategori adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 📌 2️⃣ Seçilen kategori kontrolü
            if (cbx_kategoriSecimi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kategoriID = Convert.ToInt32(cbx_kategoriSecimi.SelectedValue);

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Alt_Kategori (Isim, Kategori_ID) VALUES (@isim, @kategoriID)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@isim", altKategoriAdi);
                        cmd.Parameters.AddWithValue("@kategoriID", kategoriID);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Alt kategori başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 📌 3️⃣ GridView’i Güncelle (Yeni Alt Kategorileri Yükle)
                            string getQuery = @"SELECT AK.ID, AK.Isim AS 'Alt Kategori Adı', K.Isim AS 'Kategori Adı' 
                                        FROM Alt_Kategori AK
                                        INNER JOIN Kategori K ON AK.Kategori_ID = K.ID";

                            SqlDataAdapter da = new SqlDataAdapter(getQuery, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            DGV_altKategoriler.DataSource = dt;

                            // 📌 4️⃣ Form Elemanlarını Temizle
                            tb_altKategoriAdi.Text = "";
                            cbx_kategoriSecimi.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Alt kategori eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void KategorileriYukle()
        {
            cbx_kategoriSecimi.Items.Clear(); // Önce temizleyelim
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

                        cbx_kategoriSecimi.DataSource = new BindingSource(kategoriListesi, null);
                        cbx_kategoriSecimi.DisplayMember = "Value"; // Kullanıcıya gösterilecek değer
                        cbx_kategoriSecimi.ValueMember = "Key"; // Seçildiğinde alınacak değer (ID)
                        cbx_kategoriSecimi.SelectedIndex = -1; // Varsayılan olarak seçili olmasın
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategoriler yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btn_kategoriSil_Click(object sender, EventArgs e)
        {
            if (DGV_kategoriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir kategori seçiniz!");
                return;
            }

            int kategoriId = Convert.ToInt32(DGV_kategoriler.SelectedRows[0].Cells["No"].Value);

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                con.Open();

                // Önce kategoriye bağlı alt kategori olup olmadığını kontrol et
                string kontrolQuery = "SELECT COUNT(*) FROM Alt_Kategori WHERE Kategori_ID = @kategoriId";
                using (SqlCommand kontrolCmd = new SqlCommand(kontrolQuery, con))
                {
                    kontrolCmd.Parameters.AddWithValue("@kategoriId", kategoriId);
                    int altKategoriSayisi = (int)kontrolCmd.ExecuteScalar();

                    if (altKategoriSayisi > 0)
                    {
                        MessageBox.Show("Bu kategoriye bağlı bir alt kategori olduğu için silme işlemi gerçekleştirilememektedir!",
                                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Eğer alt kategori yoksa, kategoriyi sil
                string deleteQuery = "DELETE FROM Kategori WHERE ID = @id";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                {
                    deleteCmd.Parameters.AddWithValue("@id", kategoriId);

                    try
                    {
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Kategori başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        KategoriGetir(); // GridView'i güncelle
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            //if (DGV_kategoriler.SelectedRows.Count > 0)
            //{
            //    int kategoriId = Convert.ToInt32(DGV_kategoriler.SelectedRows[0].Cells["No"].Value);

            //    DialogResult result = MessageBox.Show("Bu kategoriyi silmek istediğinizden emin misiniz?",
            //                                          "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (result == DialogResult.Yes)
            //    {
            //        using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            //        {
            //            string query = "DELETE FROM Kategori WHERE ID = @id";
            //            using (SqlCommand cmd = new SqlCommand(query, con))
            //            {
            //                cmd.Parameters.AddWithValue("@id", kategoriId);

            //                try
            //                {
            //                    con.Open();
            //                    cmd.ExecuteNonQuery();
            //                    MessageBox.Show("Kategori başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //                    KategoriGetir(); // GridView'i yenile
            //                }
            //                catch (Exception ex)
            //                {
            //                    MessageBox.Show("Hata: " + ex.Message);
            //                }
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen silinecek bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void DGV_kategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_kategoriler.SelectedRows.Count > 0)
            {
                btn_kategoriSil.Enabled = true;  // Sil butonunu aktif et
            }
        }

        private void btn_altKategoriSil_Click(object sender, EventArgs e)
        {
            if (DGV_altKategoriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir alt kategori seçiniz!");
                return;
            }

            int altKategoriId = Convert.ToInt32(DGV_altKategoriler.SelectedRows[0].Cells["No"].Value);

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                con.Open();

                string deleteQuery = "DELETE FROM Alt_Kategori WHERE ID = @id";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                {
                    deleteCmd.Parameters.AddWithValue("@id", altKategoriId);

                    try
                    {
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Alt kategori başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AltKategoriGetir(); // GridView’i güncelle
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void KategorileriYenile()
        {
            cbx_kategoriSecimi.Items.Clear();

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Beylina_DB; Integrated Security=True"))
            {
                string query = "SELECT ID, Isim FROM Kategori";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbx_kategoriSecimi.Items.Add(new KeyValuePair<int, string>(
                                    Convert.ToInt32(reader["ID"]), reader["Isim"].ToString()));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }

            cbx_kategoriSecimi.DisplayMember = "Value";  // ComboBox'ta kategori isimlerini göstermek için
            cbx_kategoriSecimi.ValueMember = "Key";      // Seçilen değerin kategori ID olması için
        }
    }
}

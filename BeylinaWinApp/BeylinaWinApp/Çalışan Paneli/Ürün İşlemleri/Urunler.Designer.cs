namespace BeylinaWinApp.Çalışan_Paneli.Ürün_İşlemleri
{
    partial class Urunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_fiyat = new System.Windows.Forms.NumericUpDown();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.DGV_urunler = new System.Windows.Forms.DataGridView();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.tb_aciklama = new System.Windows.Forms.TextBox();
            this.tb_marka = new System.Windows.Forms.TextBox();
            this.btn_gorsel = new System.Windows.Forms.Button();
            this.pb_urunGorsel = new System.Windows.Forms.PictureBox();
            this.cb_altKategori = new System.Windows.Forms.ComboBox();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_urunGorsel)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_fiyat);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.DGV_urunler);
            this.groupBox1.Controls.Add(this.nud_stok);
            this.groupBox1.Controls.Add(this.tb_aciklama);
            this.groupBox1.Controls.Add(this.tb_marka);
            this.groupBox1.Controls.Add(this.btn_gorsel);
            this.groupBox1.Controls.Add(this.pb_urunGorsel);
            this.groupBox1.Controls.Add(this.cb_altKategori);
            this.groupBox1.Controls.Add(this.cb_kategori);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 542);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // nud_fiyat
            // 
            this.nud_fiyat.Location = new System.Drawing.Point(583, 165);
            this.nud_fiyat.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.nud_fiyat.Name = "nud_fiyat";
            this.nud_fiyat.Size = new System.Drawing.Size(174, 22);
            this.nud_fiyat.TabIndex = 21;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_kaydet.Location = new System.Drawing.Point(643, 256);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(114, 34);
            this.btn_kaydet.TabIndex = 20;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // DGV_urunler
            // 
            this.DGV_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_urunler.Location = new System.Drawing.Point(336, 296);
            this.DGV_urunler.Name = "DGV_urunler";
            this.DGV_urunler.RowHeadersWidth = 51;
            this.DGV_urunler.RowTemplate.Height = 24;
            this.DGV_urunler.Size = new System.Drawing.Size(494, 240);
            this.DGV_urunler.TabIndex = 19;
            this.DGV_urunler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGV_urunler_MouseDoubleClick);
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(583, 205);
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(174, 22);
            this.nud_stok.TabIndex = 18;
            // 
            // tb_aciklama
            // 
            this.tb_aciklama.Location = new System.Drawing.Point(583, 87);
            this.tb_aciklama.Multiline = true;
            this.tb_aciklama.Name = "tb_aciklama";
            this.tb_aciklama.Size = new System.Drawing.Size(174, 56);
            this.tb_aciklama.TabIndex = 16;
            // 
            // tb_marka
            // 
            this.tb_marka.Location = new System.Drawing.Point(583, 44);
            this.tb_marka.Name = "tb_marka";
            this.tb_marka.Size = new System.Drawing.Size(174, 22);
            this.tb_marka.TabIndex = 15;
            // 
            // btn_gorsel
            // 
            this.btn_gorsel.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_gorsel.Location = new System.Drawing.Point(156, 207);
            this.btn_gorsel.Name = "btn_gorsel";
            this.btn_gorsel.Size = new System.Drawing.Size(174, 32);
            this.btn_gorsel.TabIndex = 14;
            this.btn_gorsel.Text = "GÖRSEL EKLE";
            this.btn_gorsel.UseVisualStyleBackColor = false;
            this.btn_gorsel.Click += new System.EventHandler(this.btn_görsel_Click);
            // 
            // pb_urunGorsel
            // 
            this.pb_urunGorsel.Location = new System.Drawing.Point(9, 267);
            this.pb_urunGorsel.Name = "pb_urunGorsel";
            this.pb_urunGorsel.Size = new System.Drawing.Size(321, 269);
            this.pb_urunGorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_urunGorsel.TabIndex = 13;
            this.pb_urunGorsel.TabStop = false;
            // 
            // cb_altKategori
            // 
            this.cb_altKategori.FormattingEnabled = true;
            this.cb_altKategori.Location = new System.Drawing.Point(156, 164);
            this.cb_altKategori.Name = "cb_altKategori";
            this.cb_altKategori.Size = new System.Drawing.Size(174, 24);
            this.cb_altKategori.TabIndex = 12;
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(156, 124);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(174, 24);
            this.cb_kategori.TabIndex = 11;
            this.cb_kategori.SelectedIndexChanged += new System.EventHandler(this.cb_kategori_SelectedIndexChanged);
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(156, 84);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(174, 22);
            this.tb_isim.TabIndex = 10;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(156, 44);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(174, 22);
            this.tb_ID.TabIndex = 9;
            this.tb_ID.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "STOK: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "FİYAT: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "AÇIKLAMA: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "MARKA: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ÜRÜN GÖRSELİ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ALT KATEGORİ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "KATEGORİ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İSİM: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(94, 24);
            this.TSMI_sil.Text = "Sil";
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(860, 566);
            this.Controls.Add(this.groupBox1);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_urunGorsel)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_urunGorsel;
        private System.Windows.Forms.ComboBox cb_altKategori;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.TextBox tb_aciklama;
        private System.Windows.Forms.TextBox tb_marka;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DataGridView DGV_urunler;
        private System.Windows.Forms.NumericUpDown nud_fiyat;
        private System.Windows.Forms.Button btn_gorsel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
    }
}
namespace BeylinaWinApp.Üye_Paneli
{
    partial class Magaza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magaza));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_kategoriler = new System.Windows.Forms.ComboBox();
            this.cb_altKategoriler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_urunler = new System.Windows.Forms.PictureBox();
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.btn_satinAlMagaza = new System.Windows.Forms.Button();
            this.lbl_urunAdi = new System.Windows.Forms.Label();
            this.lbl_marka = new System.Windows.Forms.Label();
            this.lbl_aciklama = new System.Windows.Forms.Label();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BeylinaWinApp.Properties.Resources.BEYLİNA;
            this.pictureBox3.Location = new System.Drawing.Point(225, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(325, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BeylinaWinApp.Properties.Resources.BEYLİNA___Logo;
            this.pictureBox2.Location = new System.Drawing.Point(618, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BeylinaWinApp.Properties.Resources.BEYLİNA___Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lütfen seçim yapmak istediğiniz kategorileri seçiniz:";
            // 
            // cb_kategoriler
            // 
            this.cb_kategoriler.FormattingEnabled = true;
            this.cb_kategoriler.Location = new System.Drawing.Point(12, 266);
            this.cb_kategoriler.Name = "cb_kategoriler";
            this.cb_kategoriler.Size = new System.Drawing.Size(201, 24);
            this.cb_kategoriler.TabIndex = 13;
            this.cb_kategoriler.SelectedIndexChanged += new System.EventHandler(this.cb_kategoriler_SelectedIndexChanged);
            // 
            // cb_altKategoriler
            // 
            this.cb_altKategoriler.FormattingEnabled = true;
            this.cb_altKategoriler.Location = new System.Drawing.Point(12, 348);
            this.cb_altKategoriler.Name = "cb_altKategoriler";
            this.cb_altKategoriler.Size = new System.Drawing.Size(201, 24);
            this.cb_altKategoriler.TabIndex = 14;
            this.cb_altKategoriler.SelectedIndexChanged += new System.EventHandler(this.cb_altKategoriler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "KATEGORİLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "ALT KATEGORİLER";
            // 
            // pb_urunler
            // 
            this.pb_urunler.Image = global::BeylinaWinApp.Properties.Resources.BEYLİNA___Logo;
            this.pb_urunler.Location = new System.Drawing.Point(12, 465);
            this.pb_urunler.Name = "pb_urunler";
            this.pb_urunler.Size = new System.Drawing.Size(201, 206);
            this.pb_urunler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_urunler.TabIndex = 17;
            this.pb_urunler.TabStop = false;
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.Location = new System.Drawing.Point(271, 247);
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.RowHeadersWidth = 51;
            this.dgv_urunler.RowTemplate.Height = 24;
            this.dgv_urunler.Size = new System.Drawing.Size(492, 190);
            this.dgv_urunler.TabIndex = 18;
            this.dgv_urunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_urunler_CellClick);
            // 
            // btn_satinAlMagaza
            // 
            this.btn_satinAlMagaza.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_satinAlMagaza.Location = new System.Drawing.Point(121, 402);
            this.btn_satinAlMagaza.Name = "btn_satinAlMagaza";
            this.btn_satinAlMagaza.Size = new System.Drawing.Size(92, 35);
            this.btn_satinAlMagaza.TabIndex = 19;
            this.btn_satinAlMagaza.Text = "SATIN AL";
            this.btn_satinAlMagaza.UseVisualStyleBackColor = false;
            this.btn_satinAlMagaza.Click += new System.EventHandler(this.btn_satinAlMagaza_Click);
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_urunAdi.Location = new System.Drawing.Point(328, 466);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(57, 16);
            this.lbl_urunAdi.TabIndex = 20;
            this.lbl_urunAdi.Text = "Ürün adı";
            // 
            // lbl_marka
            // 
            this.lbl_marka.AutoSize = true;
            this.lbl_marka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_marka.Location = new System.Drawing.Point(328, 546);
            this.lbl_marka.Name = "lbl_marka";
            this.lbl_marka.Size = new System.Drawing.Size(45, 16);
            this.lbl_marka.TabIndex = 21;
            this.lbl_marka.Text = "Marka";
            // 
            // lbl_aciklama
            // 
            this.lbl_aciklama.AutoSize = true;
            this.lbl_aciklama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aciklama.Location = new System.Drawing.Point(328, 506);
            this.lbl_aciklama.Name = "lbl_aciklama";
            this.lbl_aciklama.Size = new System.Drawing.Size(63, 16);
            this.lbl_aciklama.TabIndex = 22;
            this.lbl_aciklama.Text = "Açıklama";
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fiyat.Location = new System.Drawing.Point(328, 586);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(36, 16);
            this.lbl_fiyat.TabIndex = 23;
            this.lbl_fiyat.Text = "Fiyat";
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stok.Location = new System.Drawing.Point(328, 626);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(34, 16);
            this.lbl_stok.TabIndex = 24;
            this.lbl_stok.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(243, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ürün adı: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(243, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Stok: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(243, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Marka: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(243, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Açıklama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(243, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Fiyat: ";
            // 
            // Magaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(775, 683);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.lbl_aciklama);
            this.Controls.Add(this.lbl_marka);
            this.Controls.Add(this.lbl_urunAdi);
            this.Controls.Add(this.btn_satinAlMagaza);
            this.Controls.Add(this.dgv_urunler);
            this.Controls.Add(this.pb_urunler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_altKategoriler);
            this.Controls.Add(this.cb_kategoriler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Magaza";
            this.Text = "Magaza";
            this.Load += new System.EventHandler(this.Magaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_kategoriler;
        private System.Windows.Forms.ComboBox cb_altKategoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_urunler;
        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.Button btn_satinAlMagaza;
        private System.Windows.Forms.Label lbl_urunAdi;
        private System.Windows.Forms.Label lbl_marka;
        private System.Windows.Forms.Label lbl_aciklama;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
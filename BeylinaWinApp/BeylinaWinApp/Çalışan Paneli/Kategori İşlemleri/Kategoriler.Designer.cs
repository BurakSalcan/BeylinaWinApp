namespace BeylinaWinApp.Çalışan_Paneli.Kategori_İşlemleri
{
    partial class Kategoriler
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
            this.btn_kategoriOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_AktifMi = new System.Windows.Forms.CheckBox();
            this.tb_aciklama = new System.Windows.Forms.TextBox();
            this.tb_kategoriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_kategoriler = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_altKategoriOlustur = new System.Windows.Forms.Button();
            this.cbx_kategoriSecimi = new System.Windows.Forms.ComboBox();
            this.tb_altKategoriAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_altKategoriler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_kategoriSil = new System.Windows.Forms.Button();
            this.btn_altKategoriSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_kategoriler)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_altKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kategoriSil);
            this.groupBox1.Controls.Add(this.btn_kategoriOlustur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_AktifMi);
            this.groupBox1.Controls.Add(this.tb_aciklama);
            this.groupBox1.Controls.Add(this.tb_kategoriAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriler";
            // 
            // btn_kategoriOlustur
            // 
            this.btn_kategoriOlustur.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_kategoriOlustur.Location = new System.Drawing.Point(120, 228);
            this.btn_kategoriOlustur.Name = "btn_kategoriOlustur";
            this.btn_kategoriOlustur.Size = new System.Drawing.Size(104, 35);
            this.btn_kategoriOlustur.TabIndex = 6;
            this.btn_kategoriOlustur.Text = "OLUŞTUR";
            this.btn_kategoriOlustur.UseVisualStyleBackColor = false;
            this.btn_kategoriOlustur.Click += new System.EventHandler(this.btn_kategoriOlustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aktif mi: ";
            // 
            // cb_AktifMi
            // 
            this.cb_AktifMi.AutoSize = true;
            this.cb_AktifMi.Location = new System.Drawing.Point(120, 183);
            this.cb_AktifMi.Name = "cb_AktifMi";
            this.cb_AktifMi.Size = new System.Drawing.Size(18, 17);
            this.cb_AktifMi.TabIndex = 4;
            this.cb_AktifMi.UseVisualStyleBackColor = true;
            // 
            // tb_aciklama
            // 
            this.tb_aciklama.Location = new System.Drawing.Point(120, 77);
            this.tb_aciklama.Multiline = true;
            this.tb_aciklama.Name = "tb_aciklama";
            this.tb_aciklama.Size = new System.Drawing.Size(171, 68);
            this.tb_aciklama.TabIndex = 3;
            // 
            // tb_kategoriAdi
            // 
            this.tb_kategoriAdi.Location = new System.Drawing.Point(120, 37);
            this.tb_kategoriAdi.Name = "tb_kategoriAdi";
            this.tb_kategoriAdi.Size = new System.Drawing.Size(171, 22);
            this.tb_kategoriAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı: ";
            // 
            // DGV_kategoriler
            // 
            this.DGV_kategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_kategoriler.Location = new System.Drawing.Point(377, 20);
            this.DGV_kategoriler.Name = "DGV_kategoriler";
            this.DGV_kategoriler.RowHeadersWidth = 51;
            this.DGV_kategoriler.RowTemplate.Height = 24;
            this.DGV_kategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_kategoriler.Size = new System.Drawing.Size(411, 291);
            this.DGV_kategoriler.TabIndex = 1;
            this.DGV_kategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_kategoriler_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_altKategoriSil);
            this.groupBox2.Controls.Add(this.btn_altKategoriOlustur);
            this.groupBox2.Controls.Add(this.cbx_kategoriSecimi);
            this.groupBox2.Controls.Add(this.tb_altKategoriAdi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 279);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alt Kategoriler";
            // 
            // btn_altKategoriOlustur
            // 
            this.btn_altKategoriOlustur.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_altKategoriOlustur.Location = new System.Drawing.Point(121, 201);
            this.btn_altKategoriOlustur.Name = "btn_altKategoriOlustur";
            this.btn_altKategoriOlustur.Size = new System.Drawing.Size(104, 35);
            this.btn_altKategoriOlustur.TabIndex = 4;
            this.btn_altKategoriOlustur.Text = "OLUŞTUR";
            this.btn_altKategoriOlustur.UseVisualStyleBackColor = false;
            this.btn_altKategoriOlustur.Click += new System.EventHandler(this.btn_altKategoriOlustur_Click);
            // 
            // cbx_kategoriSecimi
            // 
            this.cbx_kategoriSecimi.FormattingEnabled = true;
            this.cbx_kategoriSecimi.Location = new System.Drawing.Point(121, 115);
            this.cbx_kategoriSecimi.Name = "cbx_kategoriSecimi";
            this.cbx_kategoriSecimi.Size = new System.Drawing.Size(171, 24);
            this.cbx_kategoriSecimi.TabIndex = 3;
            // 
            // tb_altKategoriAdi
            // 
            this.tb_altKategoriAdi.Location = new System.Drawing.Point(121, 54);
            this.tb_altKategoriAdi.Name = "tb_altKategoriAdi";
            this.tb_altKategoriAdi.Size = new System.Drawing.Size(171, 22);
            this.tb_altKategoriAdi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kategori Seçimi: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alt Kategori Adı: ";
            // 
            // DGV_altKategoriler
            // 
            this.DGV_altKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_altKategoriler.Location = new System.Drawing.Point(377, 324);
            this.DGV_altKategoriler.Name = "DGV_altKategoriler";
            this.DGV_altKategoriler.RowHeadersWidth = 51;
            this.DGV_altKategoriler.RowTemplate.Height = 24;
            this.DGV_altKategoriler.Size = new System.Drawing.Size(411, 272);
            this.DGV_altKategoriler.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TSMI_duzenle
            // 
            this.TSMI_duzenle.Name = "TSMI_duzenle";
            this.TSMI_duzenle.Size = new System.Drawing.Size(32, 19);
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(32, 19);
            // 
            // btn_kategoriSil
            // 
            this.btn_kategoriSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_kategoriSil.Location = new System.Drawing.Point(243, 228);
            this.btn_kategoriSil.Name = "btn_kategoriSil";
            this.btn_kategoriSil.Size = new System.Drawing.Size(48, 35);
            this.btn_kategoriSil.TabIndex = 7;
            this.btn_kategoriSil.Text = "SİL";
            this.btn_kategoriSil.UseVisualStyleBackColor = false;
            this.btn_kategoriSil.Click += new System.EventHandler(this.btn_kategoriSil_Click);
            // 
            // btn_altKategoriSil
            // 
            this.btn_altKategoriSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_altKategoriSil.Location = new System.Drawing.Point(244, 201);
            this.btn_altKategoriSil.Name = "btn_altKategoriSil";
            this.btn_altKategoriSil.Size = new System.Drawing.Size(48, 34);
            this.btn_altKategoriSil.TabIndex = 5;
            this.btn_altKategoriSil.Text = "SİL";
            this.btn_altKategoriSil.UseVisualStyleBackColor = false;
            this.btn_altKategoriSil.Click += new System.EventHandler(this.btn_altKategoriSil_Click);
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.DGV_altKategoriler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGV_kategoriler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_kategoriler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_altKategoriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_aciklama;
        private System.Windows.Forms.TextBox tb_kategoriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kategoriOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_AktifMi;
        private System.Windows.Forms.DataGridView DGV_kategoriler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_altKategoriler;
        private System.Windows.Forms.TextBox tb_altKategoriAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_kategoriSecimi;
        private System.Windows.Forms.Button btn_altKategoriOlustur;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
        private System.Windows.Forms.Button btn_kategoriSil;
        private System.Windows.Forms.Button btn_altKategoriSil;
    }
}
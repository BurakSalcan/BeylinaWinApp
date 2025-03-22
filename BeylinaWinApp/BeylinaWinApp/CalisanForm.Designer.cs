namespace BeylinaWinApp
{
    partial class CalisanForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Kategoriler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KayitliKullanicilar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Calisanlar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Uyeler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Urunler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KullaniciBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_urunSayisi = new System.Windows.Forms.Label();
            this.lbl_kategoriSayisi = new System.Windows.Forms.Label();
            this.lbl_altKategoriSayisi = new System.Windows.Forms.Label();
            this.lbl_calisanSayisi = new System.Windows.Forms.Label();
            this.lbl_uyeSayisi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Kategoriler,
            this.TSMI_KayitliKullanicilar,
            this.TSMI_Urunler,
            this.TSMI_KullaniciBilgileri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Kategoriler
            // 
            this.TSMI_Kategoriler.Name = "TSMI_Kategoriler";
            this.TSMI_Kategoriler.Size = new System.Drawing.Size(97, 24);
            this.TSMI_Kategoriler.Text = "Kategoriler";
            this.TSMI_Kategoriler.Click += new System.EventHandler(this.TSMI_Kategoriler_Click);
            // 
            // TSMI_KayitliKullanicilar
            // 
            this.TSMI_KayitliKullanicilar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Calisanlar,
            this.TSMI_Uyeler});
            this.TSMI_KayitliKullanicilar.Name = "TSMI_KayitliKullanicilar";
            this.TSMI_KayitliKullanicilar.Size = new System.Drawing.Size(141, 24);
            this.TSMI_KayitliKullanicilar.Text = "Kayıtlı Kullanıcılar";
            // 
            // TSMI_Calisanlar
            // 
            this.TSMI_Calisanlar.Name = "TSMI_Calisanlar";
            this.TSMI_Calisanlar.Size = new System.Drawing.Size(156, 26);
            this.TSMI_Calisanlar.Text = "Çalışanlar";
            this.TSMI_Calisanlar.Click += new System.EventHandler(this.TSMI_Calisanlar_Click);
            // 
            // TSMI_Uyeler
            // 
            this.TSMI_Uyeler.Name = "TSMI_Uyeler";
            this.TSMI_Uyeler.Size = new System.Drawing.Size(156, 26);
            this.TSMI_Uyeler.Text = "Üyeler";
            this.TSMI_Uyeler.Click += new System.EventHandler(this.TSMI_Uyeler_Click);
            // 
            // TSMI_Urunler
            // 
            this.TSMI_Urunler.Name = "TSMI_Urunler";
            this.TSMI_Urunler.Size = new System.Drawing.Size(71, 24);
            this.TSMI_Urunler.Text = "Ürünler";
            this.TSMI_Urunler.Click += new System.EventHandler(this.TSMI_Urunler_Click);
            // 
            // TSMI_KullaniciBilgileri
            // 
            this.TSMI_KullaniciBilgileri.Name = "TSMI_KullaniciBilgileri";
            this.TSMI_KullaniciBilgileri.Size = new System.Drawing.Size(134, 24);
            this.TSMI_KullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            this.TSMI_KullaniciBilgileri.Click += new System.EventHandler(this.TSMI_KullaniciBilgileri_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(867, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(136, 20);
            this.toolStripStatusLabel1.Text = "Giriş Yapan Çalışan:";
            // 
            // lbl_urunSayisi
            // 
            this.lbl_urunSayisi.AutoSize = true;
            this.lbl_urunSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_urunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunSayisi.Location = new System.Drawing.Point(24, 88);
            this.lbl_urunSayisi.Name = "lbl_urunSayisi";
            this.lbl_urunSayisi.Size = new System.Drawing.Size(124, 20);
            this.lbl_urunSayisi.TabIndex = 3;
            this.lbl_urunSayisi.Text = "ÜRÜN SAYISI";
            // 
            // lbl_kategoriSayisi
            // 
            this.lbl_kategoriSayisi.AutoSize = true;
            this.lbl_kategoriSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kategoriSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategoriSayisi.Location = new System.Drawing.Point(24, 164);
            this.lbl_kategoriSayisi.Name = "lbl_kategoriSayisi";
            this.lbl_kategoriSayisi.Size = new System.Drawing.Size(165, 20);
            this.lbl_kategoriSayisi.TabIndex = 4;
            this.lbl_kategoriSayisi.Text = "KATEGORİ SAYISI";
            // 
            // lbl_altKategoriSayisi
            // 
            this.lbl_altKategoriSayisi.AutoSize = true;
            this.lbl_altKategoriSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_altKategoriSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_altKategoriSayisi.Location = new System.Drawing.Point(24, 236);
            this.lbl_altKategoriSayisi.Name = "lbl_altKategoriSayisi";
            this.lbl_altKategoriSayisi.Size = new System.Drawing.Size(205, 20);
            this.lbl_altKategoriSayisi.TabIndex = 5;
            this.lbl_altKategoriSayisi.Text = "ALT KATEGORİ SAYISI";
            // 
            // lbl_calisanSayisi
            // 
            this.lbl_calisanSayisi.AutoSize = true;
            this.lbl_calisanSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_calisanSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_calisanSayisi.Location = new System.Drawing.Point(24, 308);
            this.lbl_calisanSayisi.Name = "lbl_calisanSayisi";
            this.lbl_calisanSayisi.Size = new System.Drawing.Size(150, 20);
            this.lbl_calisanSayisi.TabIndex = 6;
            this.lbl_calisanSayisi.Text = "ÇALIŞAN SAYISI";
            // 
            // lbl_uyeSayisi
            // 
            this.lbl_uyeSayisi.AutoSize = true;
            this.lbl_uyeSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_uyeSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyeSayisi.Location = new System.Drawing.Point(24, 380);
            this.lbl_uyeSayisi.Name = "lbl_uyeSayisi";
            this.lbl_uyeSayisi.Size = new System.Drawing.Size(108, 20);
            this.lbl_uyeSayisi.TabIndex = 7;
            this.lbl_uyeSayisi.Text = "ÜYE SAYISI";
            // 
            // CalisanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 519);
            this.Controls.Add(this.lbl_uyeSayisi);
            this.Controls.Add(this.lbl_calisanSayisi);
            this.Controls.Add(this.lbl_altKategoriSayisi);
            this.Controls.Add(this.lbl_kategoriSayisi);
            this.Controls.Add(this.lbl_urunSayisi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalisanForm";
            this.Text = "CalisanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalisanForm_FormClosing);
            this.Load += new System.EventHandler(this.CalisanForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kategoriler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KayitliKullanicilar;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Calisanlar;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Uyeler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Urunler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KullaniciBilgileri;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lbl_urunSayisi;
        private System.Windows.Forms.Label lbl_kategoriSayisi;
        private System.Windows.Forms.Label lbl_altKategoriSayisi;
        private System.Windows.Forms.Label lbl_calisanSayisi;
        private System.Windows.Forms.Label lbl_uyeSayisi;
    }
}
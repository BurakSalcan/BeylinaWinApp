namespace BeylinaWinApp.Çalışan_Paneli
{
    partial class KullaniciBilgileri
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
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.Location = new System.Drawing.Point(12, 32);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(64, 25);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "İsim: ";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyisim.Location = new System.Drawing.Point(12, 96);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(101, 25);
            this.lbl_soyisim.TabIndex = 1;
            this.lbl_soyisim.Text = "Soyisim: ";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mail.Location = new System.Drawing.Point(12, 160);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(59, 25);
            this.lbl_mail.TabIndex = 2;
            this.lbl_mail.Text = "Mail:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(12, 224);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(64, 25);
            this.lbl_sifre.TabIndex = 3;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // KullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.lbl_isim);
            this.Name = "KullaniciBilgileri";
            this.Text = "Kullanıcı Bilgileri";
            this.Load += new System.EventHandler(this.KullaniciBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_sifre;
    }
}
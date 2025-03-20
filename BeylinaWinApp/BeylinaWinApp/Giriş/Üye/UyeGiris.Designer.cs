namespace BeylinaWinApp.Giriş
{
    partial class UyeGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_uyeKayit = new System.Windows.Forms.Button();
            this.btn_uyeGiris = new System.Windows.Forms.Button();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merhaba değerli ziyaretçi. Lütfen aşağıdaki alanlara üyelik \r\nbilgilerinizi girin" +
    "iz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eğer üye değilseniz, aşağıdaki \"KAYIT OL\" tuşuna tıklayarak \r\nkayıt olma sayfasın" +
    "a gidebilirsiniz.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_uyeKayit);
            this.groupBox1.Controls.Add(this.btn_uyeGiris);
            this.groupBox1.Controls.Add(this.tb_sifre);
            this.groupBox1.Controls.Add(this.tb_mail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // btn_uyeKayit
            // 
            this.btn_uyeKayit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_uyeKayit.Location = new System.Drawing.Point(172, 111);
            this.btn_uyeKayit.Name = "btn_uyeKayit";
            this.btn_uyeKayit.Size = new System.Drawing.Size(88, 32);
            this.btn_uyeKayit.TabIndex = 5;
            this.btn_uyeKayit.Text = "Kayıt Ol";
            this.btn_uyeKayit.UseVisualStyleBackColor = false;
            this.btn_uyeKayit.Click += new System.EventHandler(this.btn_uyeKayit_Click);
            // 
            // btn_uyeGiris
            // 
            this.btn_uyeGiris.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_uyeGiris.ForeColor = System.Drawing.Color.Black;
            this.btn_uyeGiris.Location = new System.Drawing.Point(266, 111);
            this.btn_uyeGiris.Name = "btn_uyeGiris";
            this.btn_uyeGiris.Size = new System.Drawing.Size(88, 32);
            this.btn_uyeGiris.TabIndex = 4;
            this.btn_uyeGiris.Text = "Giriş Yap";
            this.btn_uyeGiris.UseVisualStyleBackColor = false;
            this.btn_uyeGiris.Click += new System.EventHandler(this.btn_uyeGiris_Click);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(103, 83);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(251, 22);
            this.tb_sifre.TabIndex = 3;
            this.tb_sifre.Text = "1234";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(103, 40);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(251, 22);
            this.tb_mail.TabIndex = 2;
            this.tb_mail.Text = "ali@ali.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mail: ";
            // 
            // UyeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(491, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UyeGiris";
            this.Text = "BEYLİNA Üye Giriş Paneli";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_uyeKayit;
        private System.Windows.Forms.Button btn_uyeGiris;
    }
}
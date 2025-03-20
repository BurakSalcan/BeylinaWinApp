namespace BeylinaWinApp.Giriş
{
    partial class GirisSecim
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
            this.btn_uyeSecim = new System.Windows.Forms.Button();
            this.btn_calisanSecim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yapmak istediğiniz giriş türünü seçiniz: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(143, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BEYLİNA uygulamasına hoşgeldiniz. ";
            // 
            // btn_uyeSecim
            // 
            this.btn_uyeSecim.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_uyeSecim.Location = new System.Drawing.Point(134, 109);
            this.btn_uyeSecim.Name = "btn_uyeSecim";
            this.btn_uyeSecim.Size = new System.Drawing.Size(112, 47);
            this.btn_uyeSecim.TabIndex = 2;
            this.btn_uyeSecim.Text = "ÜYE";
            this.btn_uyeSecim.UseVisualStyleBackColor = false;
            this.btn_uyeSecim.Click += new System.EventHandler(this.btn_uyeSecim_Click);
            // 
            // btn_calisanSecim
            // 
            this.btn_calisanSecim.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_calisanSecim.Location = new System.Drawing.Point(371, 109);
            this.btn_calisanSecim.Name = "btn_calisanSecim";
            this.btn_calisanSecim.Size = new System.Drawing.Size(112, 47);
            this.btn_calisanSecim.TabIndex = 3;
            this.btn_calisanSecim.Text = "ÇALIŞAN";
            this.btn_calisanSecim.UseVisualStyleBackColor = false;
            this.btn_calisanSecim.Click += new System.EventHandler(this.btn_calisanSecim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(575, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eğer herhangi bir işlem yapmak istemiyorsanız çıkış yapabilirsiniz. ";
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_cikis.Location = new System.Drawing.Point(238, 245);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(133, 39);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "ÇIKIŞ YAP";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // GirisSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(692, 318);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_calisanSecim);
            this.Controls.Add(this.btn_uyeSecim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisSecim";
            this.Text = "BEYLİNA giriş seçim ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisSecim_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_uyeSecim;
        private System.Windows.Forms.Button btn_calisanSecim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cikis;
    }
}
namespace BeylinaWinApp.Üye_Paneli
{
    partial class SatinAlmaPaneli
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
            this.mtb_kartNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_satinAl = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "KART NUMARASI";
            // 
            // mtb_kartNo
            // 
            this.mtb_kartNo.Location = new System.Drawing.Point(19, 132);
            this.mtb_kartNo.Mask = "0000-0000-0000-0000";
            this.mtb_kartNo.Name = "mtb_kartNo";
            this.mtb_kartNo.Size = new System.Drawing.Size(169, 22);
            this.mtb_kartNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kart numaranızı aşağıdaki alana girip ardından alım \r\nişlemini tamamlayınız.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Eğer bir şey almayacaksanız çıkış yapabilirsiniz.";
            // 
            // btn_satinAl
            // 
            this.btn_satinAl.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_satinAl.Location = new System.Drawing.Point(37, 193);
            this.btn_satinAl.Name = "btn_satinAl";
            this.btn_satinAl.Size = new System.Drawing.Size(88, 35);
            this.btn_satinAl.TabIndex = 5;
            this.btn_satinAl.Text = "SATIN AL";
            this.btn_satinAl.UseVisualStyleBackColor = false;
            this.btn_satinAl.Click += new System.EventHandler(this.btn_satinAl_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_cikis.Location = new System.Drawing.Point(235, 193);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(88, 35);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // SatinAlmaPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(351, 248);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_satinAl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb_kartNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SatinAlmaPaneli";
            this.Text = "SatinAlmaPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_kartNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_satinAl;
        private System.Windows.Forms.Button btn_cikis;
    }
}
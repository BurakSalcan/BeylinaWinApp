namespace BeylinaWinApp.Üye_Paneli
{
    partial class UyeHesapSil
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
            this.btn_hayir = new System.Windows.Forms.Button();
            this.btn_evet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİLME İŞLEMİNİ ONAYLIYOR MUSUNUZ?";
            // 
            // btn_hayir
            // 
            this.btn_hayir.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_hayir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hayir.Location = new System.Drawing.Point(229, 107);
            this.btn_hayir.Name = "btn_hayir";
            this.btn_hayir.Size = new System.Drawing.Size(75, 40);
            this.btn_hayir.TabIndex = 4;
            this.btn_hayir.Text = "HAYIR";
            this.btn_hayir.UseVisualStyleBackColor = false;
            this.btn_hayir.Click += new System.EventHandler(this.btn_hayir_Click);
            // 
            // btn_evet
            // 
            this.btn_evet.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_evet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_evet.Location = new System.Drawing.Point(96, 107);
            this.btn_evet.Name = "btn_evet";
            this.btn_evet.Size = new System.Drawing.Size(75, 40);
            this.btn_evet.TabIndex = 3;
            this.btn_evet.Text = "EVET";
            this.btn_evet.UseVisualStyleBackColor = false;
            this.btn_evet.Click += new System.EventHandler(this.btn_evet_Click);
            // 
            // UyeHesapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(427, 180);
            this.Controls.Add(this.btn_hayir);
            this.Controls.Add(this.btn_evet);
            this.Controls.Add(this.label1);
            this.Name = "UyeHesapSil";
            this.Text = "UyeHesapSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hayir;
        private System.Windows.Forms.Button btn_evet;
    }
}
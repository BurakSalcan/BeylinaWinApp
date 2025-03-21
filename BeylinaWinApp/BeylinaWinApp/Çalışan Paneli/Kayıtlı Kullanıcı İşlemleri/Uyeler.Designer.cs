namespace BeylinaWinApp.Çalışan_Paneli.Kayıtlı_Kullanıcı_İşlemleri
{
    partial class Uyeler
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
            this.DGV_uyeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_uyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_uyeler
            // 
            this.DGV_uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_uyeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_uyeler.Location = new System.Drawing.Point(0, 0);
            this.DGV_uyeler.Name = "DGV_uyeler";
            this.DGV_uyeler.RowHeadersWidth = 51;
            this.DGV_uyeler.RowTemplate.Height = 24;
            this.DGV_uyeler.Size = new System.Drawing.Size(800, 450);
            this.DGV_uyeler.TabIndex = 0;
            // 
            // Uyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_uyeler);
            this.Name = "Uyeler";
            this.Text = "BEYLİNA Çalışanlar Üye Paneli";
            this.Load += new System.EventHandler(this.Uyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_uyeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_uyeler;
    }
}
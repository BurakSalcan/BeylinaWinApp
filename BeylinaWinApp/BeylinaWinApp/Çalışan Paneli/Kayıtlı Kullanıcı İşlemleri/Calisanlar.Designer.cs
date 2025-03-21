namespace BeylinaWinApp.Çalışan_Paneli.Kayıtlı_Kullanıcı_İşlemleri
{
    partial class Calisanlar
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
            this.DGV_calisan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_calisan)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_calisan
            // 
            this.DGV_calisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_calisan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_calisan.Location = new System.Drawing.Point(0, 0);
            this.DGV_calisan.Name = "DGV_calisan";
            this.DGV_calisan.RowHeadersWidth = 51;
            this.DGV_calisan.RowTemplate.Height = 24;
            this.DGV_calisan.Size = new System.Drawing.Size(800, 450);
            this.DGV_calisan.TabIndex = 0;
            // 
            // Calisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_calisan);
            this.Name = "Calisanlar";
            this.Text = "BEYLİNA Çalışanlar Paneli";
            this.Load += new System.EventHandler(this.Calisanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_calisan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_calisan;
    }
}
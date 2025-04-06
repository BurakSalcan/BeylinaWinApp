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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(121, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "SATIN AL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // Magaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(775, 683);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}
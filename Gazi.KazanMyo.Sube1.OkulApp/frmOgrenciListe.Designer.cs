namespace Gazi.KazanMyo.Sube1.OkulApp
{
    partial class frmOgrenciListe
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
            this.grdOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSinif = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOgrenciler
            // 
            this.grdOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOgrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAd,
            this.clmSoyad,
            this.clmNumara,
            this.clmSinif});
            this.grdOgrenciler.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdOgrenciler.Location = new System.Drawing.Point(0, 0);
            this.grdOgrenciler.Name = "grdOgrenciler";
            this.grdOgrenciler.Size = new System.Drawing.Size(575, 218);
            this.grdOgrenciler.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(205, 275);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(195, 53);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // clmAd
            // 
            this.clmAd.DataPropertyName = "Ad";
            this.clmAd.HeaderText = "Öğrenci Adı";
            this.clmAd.Name = "clmAd";
            // 
            // clmSoyad
            // 
            this.clmSoyad.DataPropertyName = "Soyad";
            this.clmSoyad.HeaderText = "Soyadı";
            this.clmSoyad.Name = "clmSoyad";
            // 
            // clmNumara
            // 
            this.clmNumara.DataPropertyName = "Numara";
            this.clmNumara.HeaderText = "Numarası";
            this.clmNumara.Name = "clmNumara";
            // 
            // clmSinif
            // 
            this.clmSinif.DataPropertyName = "Sinifid";
            this.clmSinif.HeaderText = "Sınıfı";
            this.clmSinif.Name = "clmSinif";
            this.clmSinif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmSinif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmOgrenciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grdOgrenciler);
            this.Name = "frmOgrenciListe";
            this.Text = "frmOgrenciListe";
            this.Load += new System.EventHandler(this.FrmOgrenciListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOgrenciler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumara;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmSinif;
    }
}
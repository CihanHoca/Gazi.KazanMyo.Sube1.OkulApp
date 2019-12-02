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
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOgrenciler
            // 
            this.grdOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOgrenciler.Location = new System.Drawing.Point(127, 40);
            this.grdOgrenciler.Name = "grdOgrenciler";
            this.grdOgrenciler.Size = new System.Drawing.Size(525, 218);
            this.grdOgrenciler.TabIndex = 0;
            // 
            // frmOgrenciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdOgrenciler);
            this.Name = "frmOgrenciListe";
            this.Text = "frmOgrenciListe";
            this.Load += new System.EventHandler(this.FrmOgrenciListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOgrenciler;
    }
}
namespace Gazi.KazanMyo.Sube1.OkulApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOgrenciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOgrenciKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOgrenciListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOgrenciIslemleri,
            this.öğretmenİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOgrenciIslemleri
            // 
            this.menuOgrenciIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOgrenciKayit,
            this.menuOgrenciListele});
            this.menuOgrenciIslemleri.Name = "menuOgrenciIslemleri";
            this.menuOgrenciIslemleri.Size = new System.Drawing.Size(108, 20);
            this.menuOgrenciIslemleri.Text = "Öğrenci İşlemleri";
            // 
            // öğretmenİşlemleriToolStripMenuItem
            // 
            this.öğretmenİşlemleriToolStripMenuItem.Name = "öğretmenİşlemleriToolStripMenuItem";
            this.öğretmenİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.öğretmenİşlemleriToolStripMenuItem.Text = "Öğretmen İşlemleri";
            // 
            // menuOgrenciKayit
            // 
            this.menuOgrenciKayit.Name = "menuOgrenciKayit";
            this.menuOgrenciKayit.Size = new System.Drawing.Size(216, 22);
            this.menuOgrenciKayit.Text = "Öğrenci Kayıt İşlemleri";
            this.menuOgrenciKayit.Click += new System.EventHandler(this.MenuOgrenciKayit_Click);
            // 
            // menuOgrenciListele
            // 
            this.menuOgrenciListele.Name = "menuOgrenciListele";
            this.menuOgrenciListele.Size = new System.Drawing.Size(216, 22);
            this.menuOgrenciListele.Text = "Öğrenci Listeleme İşlemleri";
            this.menuOgrenciListele.Click += new System.EventHandler(this.MenuOgrenciListele_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 623);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOgrenciIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuOgrenciKayit;
        private System.Windows.Forms.ToolStripMenuItem menuOgrenciListele;
        private System.Windows.Forms.ToolStripMenuItem öğretmenİşlemleriToolStripMenuItem;
    }
}
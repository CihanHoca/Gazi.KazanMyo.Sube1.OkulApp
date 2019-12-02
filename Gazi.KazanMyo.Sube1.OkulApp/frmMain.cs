using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.KazanMyo.Sube1.OkulApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MenuOgrenciKayit_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.WindowState = FormWindowState.Maximized;
            
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.Show();
        }

        private void MenuOgrenciListele_Click(object sender, EventArgs e)
        {
            frmOgrenciListe frm = new frmOgrenciListe();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

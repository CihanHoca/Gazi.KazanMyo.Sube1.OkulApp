using Gazi.Sube1.OkulApp.BLL;
using Gazi.Sube1.OkulApp.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.KazanMyo.Sube1.OkulApp
{
    public partial class frmBul : Form
    {
        SqlConnection cn;
        Form1 frm;

        public frmBul()
        {
            InitializeComponent();
        }

        public frmBul(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci o = obl.OgrenciBul(int.Parse(txtNo.Text.Trim()));
            if (o==null)
            {
                MessageBox.Show("Öğrenci Bulunamadı");
            }
            else
            {
                frm.txtAd.Text = o.Ad;
                frm.txtSoyad.Text = o.Soyad;
                frm.txtNumara.Text = o.Numara.ToString();
                frm.ogrenciid = o.Ogrenciid;
            }
        }



    }
}

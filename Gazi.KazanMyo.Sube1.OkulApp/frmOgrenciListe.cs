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
    public partial class frmOgrenciListe : Form
    {
        DataTable dt;
        public frmOgrenciListe()
        {
            
            InitializeComponent();
            grdOgrenciler.AutoGenerateColumns = false;


        }

        private void FrmOgrenciListe_Load(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            dt = obl.OgrenciTable();
            grdOgrenciler.DataSource = dt;
            obl.Dispose();

            SinifBL sb = new SinifBL();
            clmSinif.DataSource = sb.SinifListesi();
            clmSinif.DisplayMember = "SinifAd";
            clmSinif.ValueMember = "Sinifid";
            sb.Dispose();
            //(DataGridViewComboBoxColumn)grdOgrenciler.Columns["clmSinif"] 
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            OgrenciBL ob = new OgrenciBL();

            foreach (DataRow item in dt.Rows)
            {

                Ogrenci o = new Ogrenci();
                if (item.RowState != DataRowState.Deleted)
                {
                    o.Ad = item[1].ToString();
                    o.Soyad = item[2].ToString();
                    o.Numara = Convert.ToInt32(item[3]);
                    o.Sinifid = 1;
                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        ob.Kaydet(o);
                        break;
                    case DataRowState.Deleted:
                        ob.OgrenciSil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        o.Ogrenciid = Convert.ToInt32(item[0]);
                        ob.Guncelle(o);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

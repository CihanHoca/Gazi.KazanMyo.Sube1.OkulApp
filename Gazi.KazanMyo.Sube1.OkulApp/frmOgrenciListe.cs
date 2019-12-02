using Gazi.Sube1.OkulApp.BLL;
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
        public frmOgrenciListe()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListe_Load(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            grdOgrenciler.DataSource = obl.OgrenciTable();
            obl.Dispose();

        }
    }
}

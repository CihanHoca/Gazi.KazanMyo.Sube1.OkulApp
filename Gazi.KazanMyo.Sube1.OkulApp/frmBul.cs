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
            cn = new SqlConnection(@"Data Source=.;Initial Catalog=TestDb2;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Select OgrenciId,Ad,Soyad,Numara from tblOgrenciler where Numara=@Numara", cn);
            SqlParameter[] p = { new SqlParameter("@Numara", txtNo.Text.Trim()) };
            cmd.Parameters.AddRange(p);
            OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frm.txtAd.Text = dr["Ad"].ToString();
                frm.txtSoyad.Text = dr["Soyad"].ToString();
                frm.txtNumara.Text = dr["Numara"].ToString();

                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                
            }
            else
            {
                MessageBox.Show("Öğrenci Bulunamadı!!");
            }

            dr.Close();
            CloseConnection();


        }


        public void OpenConnection()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        public int ogrenciid = 0;
        SqlConnection cn = null;
        public Form1()
        {
            InitializeComponent();
        }
        //Katmanlı Mimari
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            try
            {

                Ogrenci ogr = new Ogrenci();
                ogr.Ad = txtAd.Text.Trim();
                ogr.Soyad = txtSoyad.Text.Trim();
                ogr.Numara = int.Parse(txtNumara.Text.Trim());
                ogr.Ogrenciid = ogrenciid;
                switch (ogrenciid)
                {
                    case 0:
                        MessageBox.Show(obl.Kaydet(ogr) ? "Başarılı" : "Başarısız");
                        break;
                    default:
                        if (obl.Guncelle(ogr))
                        {
                            ogrenciid = 0;
                            Temizle();
                            MessageBox.Show("Güncelleme Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme Başarısız!");
                        }
                        break;
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 245:
                        MessageBox.Show("Numara alanına sadece rakam giriniz");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası" + ex.Number);
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Numara alanına sadece rakam giriniz");
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
            finally
            {
                obl.Dispose();
            }

        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            frmBul frm = new frmBul(this);
            frm.Show();
        }

        void Temizle()
        {
            foreach (Control item in this.Controls["pnlText"].Controls)
            {
                item.Text = string.Empty;
            }
        }
    }
}

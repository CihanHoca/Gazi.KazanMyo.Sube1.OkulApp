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

            if (cmbSiniflar.SelectedIndex==0)
            {
                MessageBox.Show("Sınıf Seçiniz");
                cmbSiniflar.DroppedDown = true;
                return;
            }

            OgrenciBL obl = new OgrenciBL();
            try
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Ad = txtAd.Text.Trim();
                ogr.Soyad = txtSoyad.Text.Trim();
                ogr.Numara = int.Parse(txtNumara.Text.Trim());
                ogr.Ogrenciid = ogrenciid;
                ogr.Sinifid = (int)cmbSiniflar.SelectedValue;
                switch (ogrenciid)
                {
                    case 0:
                        if (obl.Kaydet(ogr))
                        {
                            MessageBox.Show("Ekleme Başarılı");
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Yeniden Deneyiniz!!");
                        }

                        break;
                    default:
                        if (obl.Guncelle(ogr))
                        {
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
            btnKaydet.Text = "Ekle";
            ogrenciid = 0;
            cmbSiniflar.SelectedIndex = 0;
            btnVazgec.Visible = false;
            btnSil.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SinifBL sb = new SinifBL();
            cmbSiniflar.DisplayMember = "SinifAd";
            cmbSiniflar.ValueMember = "SinifId";
            cmbSiniflar.DataSource = sb.SinifListesi();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            DialogResult cvp = MessageBox.Show("Kayıt Silinecek. Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cvp == DialogResult.Yes)
            {
                OgrenciBL obl = new OgrenciBL();
                if (obl.OgrenciSil(ogrenciid))
                {
                    MessageBox.Show("Silme Başarılı!");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Silme hatalı!");
                }
                obl.Dispose();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
                Temizle();
            }


        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(((int)e.KeyChar).ToString());
        }
    }
}

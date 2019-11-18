using Gazi.Sube1.DAL;
using Gazi.Sube1.OkulApp.MODELS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Sube1.OkulApp.BLL//Business Logic Layer
{
    public class OgrenciBL:IDisposable
    {
        Helper hlp = new Helper();
        public bool Kaydet(Ogrenci o)
        {
            try
            {               
                SqlParameter[] p = { new SqlParameter("@Ad", o.Ad), new SqlParameter("@Soyad", o.Soyad), new SqlParameter("@Numara", o.Numara), new SqlParameter("@SinifId", o.Sinifid) };
                return hlp.ExecuteNonQuery("Insert into tblOgrenciler values(@Ad,@Soyad,@Numara,@SinifId)", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Guncelle(Ogrenci o)
        {
            try
            {               
                SqlParameter[] p = { new SqlParameter("@Ad", o.Ad), new SqlParameter("@Soyad", o.Soyad), new SqlParameter("@Numara", o.Numara), new SqlParameter("@SinifId", o.Sinifid),new SqlParameter("@OgrenciId",o.Ogrenciid) };
                return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara Where OgrenciId=@OgrenciId", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Ogrenci OgrenciBul(int numara)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };
                SqlDataReader dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara,SinifId from tblOgrenciler Where Numara=@Numara", p);
                Ogrenci o = null;
                if (dr.Read())
                {
                    o = new Ogrenci();
                    o.Ad = dr["Ad"].ToString();
                    o.Soyad = dr["Soyad"].ToString();
                    o.Numara = Convert.ToInt32(dr["Numara"]);
                    o.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
                    o.Sinifid = Convert.ToInt32(dr["SinifId"]);
                }
                dr.Close();
                return o;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            hlp.Dispose();
        }
    }
}

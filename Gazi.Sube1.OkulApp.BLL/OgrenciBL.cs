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
    public class OgrenciBL
    {
        public bool Kaydet(Ogrenci o)
        {
            try
            {
                Helper hlp = new Helper();
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
    }
}

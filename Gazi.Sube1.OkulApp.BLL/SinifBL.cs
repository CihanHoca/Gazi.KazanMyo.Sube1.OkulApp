﻿using Gazi.Sube1.DAL;
using Gazi.Sube1.OkulApp.MODELS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Sube1.OkulApp.BLL
{
    public class SinifBL : IDisposable
    {
        Helper hlp = new Helper();

        public List<Sinif> SinifListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select SinifId,SinifAd,Kontenjan from tblSiniflar", null);
            List<Sinif> lst = new List<Sinif>();
            while (dr.Read())
            {                
                lst.Add(new Sinif { Kontenjan = Convert.ToInt32(dr["Kontenjan"]), SinifAd = dr["SinifAd"].ToString(), Sinifid = Convert.ToInt32(dr["SinifId"]) });
            }
            dr.Close();
            lst.Insert(0, new Sinif { SinifAd = "Seçiniz" });
            return lst;
        }





        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}

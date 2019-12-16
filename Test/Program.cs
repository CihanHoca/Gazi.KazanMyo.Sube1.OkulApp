using Gazi.Sube1.OkulApp.BLL;
using Gazi.Sube1.OkulApp.MODELS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //ORM-Object Relational Mapping

            //OkulContext ctx = new OkulContext();
            //ctx.tblSiniflars.Add(new tblSiniflar { Kontenjan = 20, SinifAd = "5-A" });
            //ctx.SaveChanges();

            //using (OkulContext ctx = new OkulContext())
            //{
            //    tblSiniflar sinif = ctx.tblSiniflars.Find(4);
            //    // ctx.tblSiniflars.Remove(sinif);
            //    sinif.Kontenjan = 45;
            //    ctx.Entry<tblSiniflar>(sinif).State = EntityState.Modified;
            //    ctx.SaveChanges();
            //}

            //using (OkulContext ctx = new OkulContext())
            //{
            //    List<tblSiniflar> lst = ctx.tblSiniflars.ToList();
            //    foreach (tblSiniflar item in lst)
            //    {
            //        Console.WriteLine(item.SinifId + " " + item.SinifAd + " " + item.Kontenjan);
            //    }
            //}

            //Eager Loading
            using (OkulContext ctx = new OkulContext())
            {
                List<tblOgrenciler> lst = ctx.tblOgrencilers.Include(o => o.tblSiniflar).ToList();

                foreach (tblOgrenciler item in lst)
                {
                    Console.WriteLine(item.Numara + " " + item.Ad + " " + item.Soyad + " " + item.tblSiniflar.SinifAd);
                }
            }

            //using (OkulContext ctx=new OkulContext())
            //{
            //    List<tblOgrenciler> lst = ctx.tblOgrencilers.Where(ogr => ogr.SinifId == 1).ToList();
            //    foreach (tblOgrenciler item in lst)
            //    {
            //        Console.WriteLine(item.Ad+" "+item.tblSiniflar.SinifAd);
            //    }
            //}

            //using (OkulContext ctx=new OkulContext())
            //{
            //    foreach (tblSiniflar item in ctx.tblSiniflars.Include(o=>o.tblOgrencilers))
            //    {
            //        Console.WriteLine($"Sınıf Ad:{item.SinifAd}");

            //        foreach (tblOgrenciler ogrenci in item.tblOgrencilers)
            //        {
            //            Console.WriteLine($"\tÖğrenci Adı:{ogrenci.Ad}");
            //        }
            //    }
            //}


            Console.ReadKey();
        }
    }
}

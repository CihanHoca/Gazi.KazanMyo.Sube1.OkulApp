using Gazi.Sube1.OkulApp.BLL;
using Gazi.Sube1.OkulApp.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("Ogrenci adı giriniz:");
            ogr.Ad = Console.ReadLine();
            Console.WriteLine("Soyad giriniz");
            ogr.Soyad = Console.ReadLine();
            Console.WriteLine("Numara giriniz");
            ogr.Numara = int.Parse(Console.ReadLine());
            ogr.Sinifid = 1;
            //deneme1
            OgrenciBL obl = new OgrenciBL();
            if (obl.Kaydet(ogr))
            {
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("Hata");
            }

            Console.ReadKey();
            

        }
    }
}

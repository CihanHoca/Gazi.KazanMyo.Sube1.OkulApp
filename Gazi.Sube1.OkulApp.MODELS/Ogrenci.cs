using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Sube1.OkulApp.MODELS
{
    public class Ogrenci
    {

        string ad;
        string soyad;
        public int Ogrenciid { get; set; }
        public string Ad { get => ad; set => ad = value.ToUpper(); }
        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }
        public int Numara { get; set; }
        public int Sinifid { get; set; }
    }
}

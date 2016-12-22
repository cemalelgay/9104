using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Oyuncu
    {
        public string adi;
        public string takimi;
        public byte formaNo;
        public string pozisyonu;

        public Oyuncu()
        {
            adi = "A";
            formaNo = 1;
        }
        public Oyuncu(string ad)
        {
            adi = ad;
        }
        public Oyuncu(string ad, string takim)
        {
            adi = ad;
            takimi = takim;
        }

        public Oyuncu(string ad, string takim, string pozisyon, byte fNo)
        {
            adi = ad;
            takimi = takim;
            pozisyonu = pozisyon;
            formaNo = fNo;
        }
    }
}

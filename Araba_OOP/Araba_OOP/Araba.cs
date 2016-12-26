using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_OOP
{
    class Araba
    {
        public int yakitDepoKapasite { get; set; }
        public double ortalamaTuketim100km { get; set; }
        public static double yakitFiyat { get; set; }
        public double toplamYol
        {
            get
            {
                return (yakitDepoKapasite / ortalamaTuketim100km) * 100;
            }
        }

        public double UcretHesaplama(double km)
        {
            return km * (ortalamaTuketim100km / 100) * yakitFiyat;
        }

        public Araba(int yakitKapasite, double ortTuk100km)
        {
            this.ortalamaTuketim100km = ortTuk100km;
            this.yakitDepoKapasite = yakitKapasite;
        }
    }
}

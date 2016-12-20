using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzHakikiUlusoy
{
    class Musteri
    {
        public string AdSoyAd;
        public bool Cinsiyet; // false => Erkek, true => Kadın
        public string OtobusTuru;

        public override string ToString()
        {
            return this.AdSoyAd + "\t" + this.Cinsiyet + "\t" + this.OtobusTuru;
        }
    }
}

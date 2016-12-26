using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class AA
    {
        public int X;
        public int Y { get; set; }

        private int _z;
        public string mesaj = String.Empty;
        public int Z
        {
            get
            {
                return _z;
            }
            set
            {
                //_z = value;
                if (value > 81 || value < 1)
                {
                    mesaj = "Yanlış Plaka Kodu";
                }
                else
                {
                    _z = value;
                }
            }
        }
    }
}

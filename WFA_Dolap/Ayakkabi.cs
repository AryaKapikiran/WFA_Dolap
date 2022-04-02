using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Ayakkabi : Urun
    {
        public int Numara { get; set; }

        public override string ToString()
        {
            return $"{Marka} {Model} {Numara} {Renk} {Fiyat}";
        }

    }
}

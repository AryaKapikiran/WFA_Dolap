using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Tişört : Urun
    {
        public string Beden { get; set; }

        public override string ToString()
        {
            return $"{Marka} {Model} {Beden} {Renk} {Fiyat}";
        }

    }
}

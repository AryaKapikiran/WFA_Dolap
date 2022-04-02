using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Urun
    {
        public string Renk { get; set; }

        public string Marka { get; set; } 

        public decimal Fiyat { get; set; }

        public string Model { get; set; }

        public string Kategori { get; set; }
        public decimal KDVfiyat 
        { 
            
            get
            {
                return Fiyat* 1.18m;
            } 
            
            
        
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga_hot_spots
{
    class Locus
    {
        protected byte allele;
        protected bool hotspot;

        public byte Allele
        {
            get { return allele; }
            set { allele = value; }
        }

        public bool Hotspot
        {
            get { return hotspot; }
            set { hotspot = value; }
        }

        public Locus ()
        {
            allele = 0;
            hotspot = false;
        }

        public Locus(byte in_allele, bool in_hotspot = false)
        {
            allele = in_allele;
            hotspot = in_hotspot;
        }
    }
}

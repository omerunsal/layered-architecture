using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.DTO
{
    public class YazarDTO
    {
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public string Ozgecmis { get; set; }
        //---------------------------------------------
        public override string ToString()
        {
            return this.YazarAd + " " + YazarSoyad;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.DTO
{
    public class KitapDTO
    {
        public int KitapID { get; set; }
        public string KitapAd { get; set; }
        public string KitapKonu { get; set; }
        public string YayinEv { get; set; }
        public DateTime YayinTarih { get; set; }
        public int YazarID { get; set; }
        //---------------------------------------------
        public override string ToString()
        {
            return this.KitapAd;
        }
    }
}

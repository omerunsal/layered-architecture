using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.DTO
{
    public class KitapDataSourceDTO
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        //--------------------------------------
        public override string ToString()
        {
            return this.KitapAdi;
        }
    }
}

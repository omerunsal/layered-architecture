using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.DTO
{
    public class YazarDataSourceDTO
    {
        public int YazarID { get; set; }
        public string AdiSoyadi { get; set; }
        //--------------------------------------
        public override string ToString()
        {
            return this.AdiSoyadi;
        }
    }
}

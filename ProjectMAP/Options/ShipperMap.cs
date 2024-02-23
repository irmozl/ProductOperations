using ProjectENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMAP.Options
{
    public class ShipperMap:BaseMap<Shipper>
    {
        public ShipperMap() 
        {
            ToTable("Kargocular");
            Property(x => x.CompanyName).HasColumnName("Şirket İsmi");
        }
    }
}

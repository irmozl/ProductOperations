using ProjectENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMAP.Options
{
    public class OrderMap:BaseMap<Order>
    {
        public OrderMap() 
        {
            ToTable("Sİparişler");
            Property(x => x.ShippedAddres).HasColumnName("Teslim Adresi");
        }
    }
}

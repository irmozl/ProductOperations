using ProjectENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMAP.Options
{
    public class ProductMap: BaseMap<Product>
    {
        public ProductMap() {

            ToTable("Ürünler");
            Property(x => x.ProductName).HasColumnName("Ürün İsmi");
            Property(x => x.UnitPrice).HasColumnName("Fiyat").HasColumnType("money");
        }
    }
}

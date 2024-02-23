using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectENTITIES.Models
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational properties
        public virtual AppUserProfile AppUserProfile { get; set; }
        public virtual List<Order> Order { get; set; }
    }
}

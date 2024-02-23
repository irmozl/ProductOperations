using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectENTITIES.Models
{
    public class AppUserProfile:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone {  get; set; }
        public string Address { get; set; }

        //relational properties
        public virtual AppUser  AppUser { get; set; }
    
    }
}

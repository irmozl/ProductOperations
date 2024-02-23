using ProjectENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMAP.Options
{
    public class AppUserProfileMap:BaseMap<AppUserProfile>
    {
        public AppUserProfileMap()
        {
            ToTable("Kullanıcı Profilleri");
            Property(x => x.FirstName).HasColumnName("İsim");
            Property(x => x.LastName).HasColumnName("Soyisim");

        }
    }
}

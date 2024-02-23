using ProjectENTITIES.Models;
using ProjectMAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL.Context
{
    public class MyContext : DbContext

    {
        public MyContext() : base("MyConnection")
        {
        }    
        
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserProfileMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ShipperMap());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set;}
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; } 
        public DbSet<Category> Category { get; set; }   
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        
    }
}

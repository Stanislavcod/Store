using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Entities;

namespace OnlineStore
{
    public class ApplicationContext : DbContext
    {
        #region DbSet<>
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Issuance> Issuances { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Category> Categories { get; set; }
        #endregion
    public DbSet<ProductSuppliersGroup> ProductSuppliersGroup { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // at startup, the date and user name are recorded
            modelBuilder.Entity<Log>().HasData(new Log { Id = 1,DateTime = DateTime.Now, UserName = System.Environment.UserName });

            modelBuilder.Entity<Phone>().HasOne(p => p.User).WithMany(t => t.Phones).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ProductSuppliersGroup>((ps => { ps.HasNoKey(); ps.ToView("ProductSuppliersGroup"); }));
        }
       
    }
}

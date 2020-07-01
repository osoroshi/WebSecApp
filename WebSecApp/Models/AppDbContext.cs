using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebSecApp.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       
        public DbSet<SecService> SecSer { get; set; }
       // public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ////seed categories
            //modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies" });
            //modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese cakes" });
            //modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal pies" });

            //seed pies

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 1,
                prodcode = "CTXSF1",
                servName = "WAF Design",
                technology = "Citrix",
                projecttype ="Fixed",
                projduration = 10    
                
            });

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 2,
                prodcode = "CTXSF2",
                servName = "WAF Build ",
                technology = "Citrix",
                projecttype = "Fixed",
                projduration = 20

            });

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 3,
                prodcode = "CTXST3",
                servName = "WAF Testing ",
                technology = "Citrix",
                projecttype = "T&M",
                projduration = 5

            });

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 4,
                prodcode = "CTXST4",
                servName = "WAF Prod Deploy",
                technology = "Citrix",
                projecttype = "T&M",
                projduration = 15

            });

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 5,
                prodcode = "AZSF1",
                servName = "Azure Firewall ",
                technology = "Microsoft",
                projecttype = "Fixed",
                projduration = 20

            });

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 6,
                prodcode = "AZSF2",
                servName = "Azure Sentinel",
                technology = "Microsoft",
                projecttype = "Fixed",
                projduration = 25

            });

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 8,
                prodcode = "AZSF3",
                servName = "Azure Security Centre",
                technology = "Microsoft",
                projecttype = "Fixed",
                projduration = 30

            });

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 9,
                prodcode = "AZST4",
                servName = "Citrix ADC WAF on Azure ",
                technology = "Microsoft",
                projecttype = "T&M",
                projduration = 15

            });

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 10,
                prodcode = "AZST4",
                servName = "Azure Endpoint Protection",
                technology = "Microsoft",
                projecttype = "T&M",
                projduration = 15

            });

            modelBuilder.Entity<SecService>().HasData(new SecService
            {
                id = 11,
                prodcode = "CTXSF5",
                servName = "Citrix ADC Adnvanced WAF",
                technology = "Microsoft",
                projecttype = "Citrix",
                projduration = 15

            });



        }
    }
}


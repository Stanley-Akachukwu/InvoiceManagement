using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.WebAPI.Data.Entities;

namespace TakeHome.WebAPI.Data
{
    public class TakeHomeDbContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }

        public TakeHomeDbContext(DbContextOptions<TakeHomeDbContext> options)
          : base(options)
        {
        }
       // public static readonly Guid InvoiceNumber = new Guid("5C60F693-BEF5-E011-A587-80EE7300C696");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>(i =>
            {
                modelBuilder.Entity<Invoice>().Property(x => x.InvoiceNumber).HasDefaultValueSql("NEWID()");
                i.HasData(new Invoice
                {
                   InvoiceNumber= Guid.NewGuid(),
                  Description= "Tax Invoice",
                  Amount= 45000,
                   InvoiceDate= DateTime.Now,
                    DeliveryDate = DateTime.Now,
                    InvoiceVat=  "7.5",
                    Currency=    "$",
                    ExchangeRate= "4.30",
                    OrderNumber= "ORD3092",
                    SalesAgent= "Agent0982",
                    Client="Zubby Inc."
                });
            });
        }
    }
}
 
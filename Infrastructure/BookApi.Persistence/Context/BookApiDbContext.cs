using BookWebApi.Domain;
using BookWebApi.Domain.Entities;
using BookWebApi.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Persistence.Context
{
    public class BookApiDbContext : IdentityDbContext<User,Role,Guid>
    {
        public BookApiDbContext() { }
        public BookApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
      
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookOrder> BookOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

using BookWebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Persistence.Configurations
{
    public class BookOrderConfiguration : IEntityTypeConfiguration<BookOrder>
    {
        public void Configure(EntityTypeBuilder<BookOrder> builder)
        {
            builder.HasKey(x => new {x.BookId, x.OrderId});
            builder.HasOne(b=>b.Book)
                .WithMany(bo=>bo.BookOrders)
                .HasForeignKey(b=>b.BookId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Order)
                .WithMany(bo => bo.BookOrders)
                .HasForeignKey(o =>o.OrderId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}

using Bogus;
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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            Faker faker = new("tr");

            Order order1 = new()
            {
                Id = 1,
                Address=faker.Address.FullAddress(),
                OrderDescription=faker.Lorem.Sentence(5),
                CustomerId=1,
                CreatedDate=DateTime.Now,
                IsDeleted=false,

            };

            Order order2 = new()
            {
                Id = 2,
                Address = faker.Address.FullAddress(),
                OrderDescription = faker.Lorem.Sentence(5),
                CustomerId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            };

            Order order3 = new()
            {
                Id = 3,
                Address = faker.Address.FullAddress(),
                OrderDescription = faker.Lorem.Sentence(5),
                CustomerId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            };

            builder.HasData(order1,order2,order3);
        }
    }
}

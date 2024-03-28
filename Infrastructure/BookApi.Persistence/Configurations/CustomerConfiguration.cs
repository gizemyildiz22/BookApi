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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);
            builder.Property(x => x.Surname).HasMaxLength(256);

            Faker faker = new("tr");

            Customer customer1 = new()
            {
                Id= 1,
                Name = faker.Person.FirstName,
                Surname = faker.Person.LastName,
                Email = faker.Person.Email,
                Phone= faker.Phone.PhoneNumber(), 
                CreatedDate= DateTime.Now,  
                IsDeleted= false,
            };
            Customer customer2 = new()
            {
                Id = 2,
                Name = faker.Person.FirstName,
                Surname = faker.Person.LastName,
                Email = faker.Person.Email,
                Phone = faker.Phone.PhoneNumber(),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            Customer customer3 = new()
            {
                Id = 3,
                Name = faker.Person.FirstName,
                Surname = faker.Person.LastName,
                Email = faker.Person.Email,
                Phone = faker.Phone.PhoneNumber(),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            builder.HasData(customer1, customer2, customer3);
        }
    }
}

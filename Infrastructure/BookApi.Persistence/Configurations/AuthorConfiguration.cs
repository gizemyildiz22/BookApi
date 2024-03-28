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
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
          builder.Property(x=>x.AuthorName).HasMaxLength(256);
            builder.Property(x => x.AuthorSurname).HasMaxLength(256);
            Faker faker = new("tr");
            Author author1 = new()
            {
                Id = 1,
                AuthorName=faker.Person.FirstName,
                AuthorSurname= faker.Person.LastName,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            Author author2 = new()
            {
                Id = 2,
                AuthorName = faker.Person.FirstName,
                AuthorSurname = faker.Person.LastName,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            Author author3 = new()
            {
                Id = 3,
                AuthorName = faker.Person.FirstName,
                AuthorSurname = faker.Person.LastName,
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };

            builder.HasData(author1, author2,author3);

        }
    }
}

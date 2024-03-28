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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            Faker faker = new("tr");

            Book book1 = new()
            {
                Id = 1,
                book_Name = faker.Commerce.ProductName(),
                book_Description = faker.Commerce.ProductDescription(),
                book_Url = faker.Commerce.Product(),
                print_Length = faker.Random.Number(10, 1000),
                AuthorId = 1,
                Price =faker.Finance.Amount(10,1000),
                Stock=faker.Random.Number(10,1000), 
                ISBN = faker.Random.Number(10, 1000),
                CategoryId=1,
                CreatedDate=DateTime.Now,
                IsDeleted=true,
            };

            Book book2 = new()
            {
                Id = 2,
                book_Name = faker.Commerce.ProductName(),
                book_Description = faker.Commerce.ProductDescription(),
                book_Url = faker.Commerce.Product(),
                print_Length = faker.Random.Number(10, 1000),
                AuthorId = 2,
                Price = faker.Finance.Amount(10, 1000),
                Stock = faker.Random.Number(10, 1000),
                ISBN = faker.Random.Number(10, 1000),
                CategoryId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };

            Book book3 = new()
            {
                Id = 3,
                book_Name = faker.Commerce.ProductName(),
                book_Description = faker.Commerce.ProductDescription(),
                book_Url = faker.Commerce.Product(),
                print_Length = faker.Random.Number(10, 1000),
                AuthorId = 1,
                Price = faker.Finance.Amount(10, 1000),
                Stock = faker.Random.Number(10, 1000),
                ISBN = faker.Random.Number(10, 1000),
                CategoryId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };

            builder.HasData(book1,book2,book3);

        }
    }
}

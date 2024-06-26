﻿using BookWebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id=1,
                CategoryName="Roman",
                IsDeleted =false,
                CreatedDate=DateTime.Now,   
            };

            Category category2 = new()
            {
                Id = 2,
                CategoryName = "Şiir Kitabı",
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };

            Category category3 = new()
            {
                Id = 3,
                CategoryName = "Çocuk Kitabı",
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };

            builder.HasData(category1, category2, category3);
        }
    }
}

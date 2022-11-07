using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            List<Category> CategoryList = new List<Category>();
            CategoryList.Add(new Category
            {
                CategoryName = "Beverages",
                CategoryID = Guid.Parse("46810525-690d-4629-8f34-4c3001f1c39d"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                IsDeleted = false
            }) ;
            CategoryList.Add(new Category {
                CategoryName = "Dairy",
                CategoryID = Guid.Parse("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                IsDeleted = false
            });
            CategoryList.Add(new Category {
                CategoryName = "Meat",
                CategoryID = Guid.Parse("e23b1970-fc07-458a-85a3-9ed6e63d4486"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                IsDeleted = false
            });
            CategoryList.Add(new Category {
                CategoryName = "Personal Care",
                CategoryID = Guid.Parse("564a7f8c-f6c6-4e11-8420-c4e386fd9429"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                IsDeleted = false
            });
            builder.HasData(CategoryList.ToArray());
        }
    }
}

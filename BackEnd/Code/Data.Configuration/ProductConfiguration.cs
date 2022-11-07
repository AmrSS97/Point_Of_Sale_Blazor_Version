using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product {
                ProductName = "beef sausage",
                ProductDetails = "about 20pcs/kg",
                DiscountPercentage = 10,
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy=Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy=Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                CategoryID=Guid.Parse("e23b1970-fc07-458a-85a3-9ed6e63d4486"),
                SupplierID=Guid.Parse("9c03f412-e4ad-40f5-9cdb-c5efab612acf"),
                Stock = 100,
                Price = 50,
                IsDeleted = false
            }) ;
            ProductList.Add(new Product {
                ProductName = "old romano cheese",
                ProductDetails = "about 4pcs/kg",
                DiscountPercentage = 5,
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                CategoryID = Guid.Parse("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"),
                SupplierID = Guid.Parse("33b3885b-bf26-43b4-a214-b54b7f682696"),
                Stock = 150,
                Price = 20,
                IsDeleted = false
            });
            ProductList.Add(new Product {
                ProductName = "dove soap",
                ProductDetails = "soap with flower scent",
                DiscountPercentage = 3,
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                CategoryID = Guid.Parse("564a7f8c-f6c6-4e11-8420-c4e386fd9429"),
                SupplierID = Guid.Parse("34b3995b-bf26-43b4-a214-b54b7f682786"),
                Stock = 50,
                Price = 15,
                IsDeleted = false
            });
            ProductList.Add(new Product {
                ProductName = "coca cola",
                ProductDetails = "coca cola can 200ml",
                DiscountPercentage = 2,
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                CategoryID = Guid.Parse("46810525-690d-4629-8f34-4c3001f1c39d"),
                SupplierID = Guid.Parse("34b3885b-bf26-43b4-a214-b54b7f682796"),
                Stock = 200,
                Price = 10,
                IsDeleted = false
            });

            builder.HasData(ProductList.ToArray());
        }
    }
}

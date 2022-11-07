using Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>,IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
         : base(dbFactory, securityHelper) { }

        public ProductDTO GetProductDtoByID(Guid ProductID)
        {
            return DbContext.Products.Where(p => p.ProductID == ProductID).Include(p => p.Supplier).Include(p => p.Category).Select(p => new ProductDTO
            { 
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                ProductDetails = p.ProductDetails,
                CategoryName = p.Category.CategoryName,
                SupplierName = p.Supplier.SupplierName,
                SupplierPhone = p.Supplier.SupplierPhone,
                Price = p.Price,
                Stock = p.Stock,
                DiscountPercentage = p.DiscountPercentage
            })
            .AsNoTracking()
            .FirstOrDefault();
        }

        public Product GetProductByName(string ProductName)
        {
            return DbContext.Products.Where(p => p.ProductName == ProductName && p.IsDeleted == false).AsNoTracking().FirstOrDefault();
        }

        public List<ProductDTO> GetProductDtoList()
        {
            return DbContext.Products.Where(p => p.IsDeleted == false).Include(p => p.Category).Include(p => p.Supplier).Select(p => new ProductDTO
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                ProductDetails = p.ProductDetails,
                CategoryName = p.Category.CategoryName,
                SupplierName = p.Supplier.SupplierName,
                SupplierPhone = p.Supplier.SupplierPhone,
                Price = p.Price,
                Stock = p.Stock,
                DiscountPercentage = p.DiscountPercentage

            }).AsNoTracking()
              .ToList();
        }
    }
}

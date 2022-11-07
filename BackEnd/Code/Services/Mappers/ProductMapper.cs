using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProductMapper : IProductMapper
    {
        private readonly ICategoryService CategoryService;
        private readonly ISupplierService SupplierService;
            public ProductMapper(ICategoryService CategoryService, ISupplierService SupplierService)
           {
            this.CategoryService = CategoryService;
            this.SupplierService = SupplierService;
           }
        public Product MapProductDtoToProduct(ProductDTO ProductDto)
        {
            Product ProductObj = new Product();
            ProductObj.ProductID = ProductDto.ProductID;
            ProductObj.ProductDetails = ProductDto.ProductDetails;
            ProductObj.Price = ProductDto.Price;
            ProductObj.CategoryID = CategoryService.GetCategoryByName(ProductDto.CategoryName).CategoryID;
            ProductObj.DiscountPercentage = ProductDto.DiscountPercentage;
            ProductObj.SupplierID = SupplierService.GetSupplierByPhone(ProductDto.SupplierPhone).SupplierID;
            ProductObj.Stock = ProductDto.Stock;
            ProductObj.ProductName = ProductDto.ProductName;
            ProductObj.IsDeleted = false;
            return ProductObj;
        }

        public Product MapProductDtoToProduct(Product ProductObj,ProductDTO ProductDto)
        {
            ProductObj.ProductID = ProductDto.ProductID;
            ProductObj.ProductDetails = ProductDto.ProductDetails;
            ProductObj.Price = ProductDto.Price;
            ProductObj.CategoryID = CategoryService.GetCategoryByName(ProductDto.CategoryName).CategoryID;
            ProductObj.DiscountPercentage = ProductDto.DiscountPercentage;
            ProductObj.SupplierID = SupplierService.GetSupplierByPhone(ProductDto.SupplierPhone).SupplierID;
            ProductObj.Stock = ProductDto.Stock;
            ProductObj.ProductName = ProductDto.ProductName;
            return ProductObj;
        }
    }
}

using Data.Infrastructure;
using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository ProductRepository;
        private readonly IUnitOfWork UnitOfWork;

        public ProductService(IProductRepository ProductRepository, IUnitOfWork UnitOfWork)
        {
            this.ProductRepository = ProductRepository;
            this.UnitOfWork = UnitOfWork;
        }
        public void CreateProduct(Product Product)
        {
            ProductRepository.Add(Product);
        }

        public void DeleteProduct(Product Product)
        {
            ProductRepository.Delete(Product);
        }

        public Product GetProductByID(Guid ProductID)
        {
            return ProductRepository.GetById(ProductID);
        }

        public Product GetProductByName(string ProductName)
        {
            return ProductRepository.GetProductByName(ProductName);
        }

        public ProductDTO GetProductDtoByID(Guid ProductID)
        {
            return ProductRepository.GetProductDtoByID(ProductID);
        }

        public List<ProductDTO> GetProductDtoList()
        {
            return ProductRepository.GetProductDtoList();
        }

        public void SaveProduct()
        {
            UnitOfWork.Commit();
        }

        public void UpdateProduct(Guid ProductID, Product Product)
        {
            ProductRepository.Update(ProductID, Product);
        }

        public ResultDTO ValidateProduct(ProductDTO ProductDto)
        {
            ResultDTO result = new ResultDTO();
            ErrorDTO error = new ErrorDTO();
            Product ValidateProduct = GetProductByName(ProductDto.ProductName);
            if(ProductDto.ProductID == Guid.Empty && ValidateProduct != null)
            {
                    error.ErrorMessageEN = "Product Already Exists !";
                    result.Errors.Add(error);
                    return result;
            }
            if(ProductDto.ProductID != Guid.Empty && ProductDto.ProductID != ValidateProduct.ProductID)
            {
                error.ErrorMessageEN = "Product Already Exists !";
                result.Errors.Add(error);
                return result;
            }

            return result;
        }
        public void UpdateProductStockAfterPurchase(PurchaseOrder PurchaseOrderObj)
        {

            Product ProductObj = GetProductByID(PurchaseOrderObj.ProductID);
            ProductObj.Stock += PurchaseOrderObj.PurchasedQuantity;
            UpdateProduct(ProductObj.ProductID, ProductObj);
            SaveProduct();
        }

        public void UpdateProductStockBeforeDelete(PurchaseOrder PurchaseOrderObj)
        {
            Product ProductObj = GetProductByID(PurchaseOrderObj.ProductID);
            ProductObj.Stock -= PurchaseOrderObj.PurchasedQuantity;
            UpdateProduct(ProductObj.ProductID,ProductObj);
            SaveProduct();
        }

        public void UpdateProductStockAfterSale(List<Item> ItemList)
        {
            foreach(Item Item in ItemList)
            {
                Product ProductObj = GetProductByID(Item.ProductID);
                ProductObj.Stock -= Item.ItemQuantity;
                UpdateProduct(ProductObj.ProductID,ProductObj);
                SaveProduct();
            }
        }

        public ProductDTO SoftDeleteProduct(Guid ProductID)
        {
            Product ProductObj = GetProductByID(ProductID);
            ProductDTO ProductDto = GetProductDtoByID(ProductID);
            ProductObj.IsDeleted = true;
            UpdateProduct(ProductID, ProductObj);
            SaveProduct();

            return ProductDto;
        }

        public void UpdateProductStockAfterRefund(List<Item> ItemList)
        {
           foreach(Item Item in ItemList)
            {
                Product ProductObj = GetProductByID(Item.ProductID);
                ProductObj.Stock += Item.ItemQuantity;
                UpdateProduct(ProductObj.ProductID,ProductObj);
                SaveProduct();
            }
        }
    }
}

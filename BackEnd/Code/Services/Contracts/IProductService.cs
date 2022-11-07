using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IProductService
    {
        void CreateProduct(Product Product);
        void DeleteProduct(Product Product);
        ProductDTO SoftDeleteProduct(Guid ProductID);
        void UpdateProduct(Guid ProductID,Product Product);
        void SaveProduct();
        List<ProductDTO> GetProductDtoList();
        ProductDTO GetProductDtoByID(Guid ProductID);
        Product GetProductByID(Guid ProductID);
        Product GetProductByName(string ProductName);
        ResultDTO ValidateProduct(ProductDTO ProductDto);
        void UpdateProductStockAfterPurchase(PurchaseOrder PurchaseOrderObj);
        void UpdateProductStockBeforeDelete(PurchaseOrder PurchaseOrderObj);
        void UpdateProductStockAfterSale(List<Item> ItemList);
        void UpdateProductStockAfterRefund(List<Item> ItemList);
    }
}

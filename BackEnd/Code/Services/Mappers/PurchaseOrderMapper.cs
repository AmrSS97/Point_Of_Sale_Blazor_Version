using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class PurchaseOrderMapper : IPurchaseOrderMapper
    {
        private readonly IProductService ProductService;
        private readonly ISupplierService SupplierService;

        public PurchaseOrderMapper(IProductService ProductService, ISupplierService SupplierService)
        {
            this.ProductService = ProductService;
            this.SupplierService = SupplierService;
        }
        public PurchaseOrder MapPurchaseOrderDtoToPurchaseOrder(PurchaseOrderDTO PurchaseOrderDto)
        {
            PurchaseOrder PurchaseOrderObj = new PurchaseOrder();
            PurchaseOrderObj.PurchaseDate = PurchaseOrderDto.PurchaseDate;
            PurchaseOrderObj.PurchasedQuantity = PurchaseOrderDto.PurchasedQuantity;
            PurchaseOrderObj.SupplierID = SupplierService.GetSupplierByPhone(PurchaseOrderDto.SupplierPhone).SupplierID;
            PurchaseOrderObj.UnitPrice = PurchaseOrderDto.UnitPrice;
            PurchaseOrderObj.ProductID = ProductService.GetProductByName(PurchaseOrderDto.ProductName).ProductID;
            PurchaseOrderObj.IsDeleted = false;

            return PurchaseOrderObj;
        }

        public PurchaseOrder MapPurchaseOrderDtoToPurchaseOrder(PurchaseOrder PurchaseOrderObj, PurchaseOrderDTO PurchaseOrderDto)
        {
            PurchaseOrderObj.PurchaseDate = PurchaseOrderDto.PurchaseDate;
            PurchaseOrderObj.PurchasedQuantity = PurchaseOrderDto.PurchasedQuantity;
            PurchaseOrderObj.SupplierID = SupplierService.GetSupplierByPhone(PurchaseOrderDto.SupplierPhone).SupplierID;
            PurchaseOrderObj.UnitPrice = PurchaseOrderDto.UnitPrice;
            PurchaseOrderObj.ProductID = ProductService.GetProductByName(PurchaseOrderDto.ProductName).ProductID;

            return PurchaseOrderObj;
        }
    }
}

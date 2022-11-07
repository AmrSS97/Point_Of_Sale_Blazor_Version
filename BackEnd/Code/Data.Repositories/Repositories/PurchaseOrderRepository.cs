using Data.Infrastructure;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class PurchaseOrderRepository : BaseRepository<PurchaseOrder>,IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
         : base(dbFactory, securityHelper) { }

        public PurchaseOrderDTO GetPurchaseOrderDtoByID(Guid PurchaseOrderID)
        {
            return DbContext.PurchaseOrders.Include(p => p.Product).Include(p => p.Supplier).Where(p => p.PurchaseOrderID == PurchaseOrderID).Select(p => new PurchaseOrderDTO
            {
                PurchaseOrderID = p.PurchaseOrderID,
                PurchaseDate = p.PurchaseDate,
                PurchasedQuantity = p.PurchasedQuantity,
                ProductName = p.Product.ProductName,
                UnitPrice = p.UnitPrice,
                SupplierName = p.Supplier.SupplierName,
                SupplierPhone = p.Supplier.SupplierPhone
            }).AsNoTracking()
              .FirstOrDefault();
        }

        public List<PurchaseOrderDTO> GetPurchaseOrderDtoList()
        {
            return DbContext.PurchaseOrders.Where(p => p.IsDeleted == false).Include(p => p.Supplier).Include(p => p.Product).Select(p => new PurchaseOrderDTO
            {
                PurchaseOrderID = p.PurchaseOrderID,
                PurchaseDate = p.PurchaseDate,
                PurchasedQuantity = p.PurchasedQuantity,
                ProductName = p.Product.ProductName,
                UnitPrice = p.UnitPrice,
                SupplierName = p.Supplier.SupplierName,
                SupplierPhone = p.Supplier.SupplierPhone
            }).AsNoTracking()
              .ToList();
        }
    }
}

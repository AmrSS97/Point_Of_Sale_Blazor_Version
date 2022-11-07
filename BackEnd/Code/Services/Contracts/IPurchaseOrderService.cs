using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IPurchaseOrderService
    {
        void CreatePurchaseOrder(PurchaseOrder PurchaseOrder);
        void DeletePurchaseOrder(PurchaseOrder PurchaseOrder);
        PurchaseOrderDTO SoftDeletePurchaseOrder(Guid PurchaseOrderID);
        void UpdatePurchaseOrder(Guid PurchaseOrderID,PurchaseOrder PurchaseOrder);
        void SavePurchaseOrder();
        List<PurchaseOrderDTO> GetPurchaseOrderDtoList();
        PurchaseOrderDTO GetPurchaseOderDtoByID(Guid PurchaseOrderID);
        PurchaseOrder GetPurchaseOrderByID(Guid PurchaseOrderID);
    }
}

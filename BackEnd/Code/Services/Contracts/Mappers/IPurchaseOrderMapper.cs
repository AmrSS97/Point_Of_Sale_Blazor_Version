using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IPurchaseOrderMapper
    {
        public PurchaseOrder MapPurchaseOrderDtoToPurchaseOrder(PurchaseOrderDTO PurchaseOrderDto);
        public PurchaseOrder MapPurchaseOrderDtoToPurchaseOrder(PurchaseOrder PurchaseOrderObj , PurchaseOrderDTO PurchaseOrderDto);
    }
}

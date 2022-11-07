using Data.Infrastructure;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface IPurchaseOrderRepository : IRepository<PurchaseOrder>
    {
        List<PurchaseOrderDTO> GetPurchaseOrderDtoList();
        PurchaseOrderDTO GetPurchaseOrderDtoByID(Guid PurchaseOrderID);
    }
}

using Data.Infrastructure;
using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository PurchaseOrderRepository;
        private readonly IUnitOfWork UnitOfWork;

        public PurchaseOrderService(IPurchaseOrderRepository PurchaseOrderRepository, IUnitOfWork UnitOfWork)
        {
            this.PurchaseOrderRepository = PurchaseOrderRepository;
            this.UnitOfWork = UnitOfWork;
        }
        public void CreatePurchaseOrder(PurchaseOrder PurchaseOrder)
        {
            PurchaseOrderRepository.Add(PurchaseOrder);
        }

        public void DeletePurchaseOrder(PurchaseOrder PurchaseOrder)
        {
            PurchaseOrderRepository.Delete(PurchaseOrder);
        }

        public PurchaseOrderDTO GetPurchaseOderDtoByID(Guid PurchaseOrderID)
        {
            return PurchaseOrderRepository.GetPurchaseOrderDtoByID(PurchaseOrderID);
        }

        public PurchaseOrder GetPurchaseOrderByID(Guid PurchaseOrderID)
        {
            return PurchaseOrderRepository.GetById(PurchaseOrderID);
        }

        public List<PurchaseOrderDTO> GetPurchaseOrderDtoList()
        {
            return PurchaseOrderRepository.GetPurchaseOrderDtoList();
        }

        public void SavePurchaseOrder()
        {
            UnitOfWork.Commit();
        }

        public PurchaseOrderDTO SoftDeletePurchaseOrder(Guid PurchaseOrderID)
        {
            PurchaseOrder PurchaseOrderObj = GetPurchaseOrderByID(PurchaseOrderID);
            PurchaseOrderDTO PurchaseOrderDto = GetPurchaseOderDtoByID(PurchaseOrderID);
            PurchaseOrderObj.IsDeleted = true;
            UpdatePurchaseOrder(PurchaseOrderID,PurchaseOrderObj);
            SavePurchaseOrder();

            return PurchaseOrderDto;
        }

        public void UpdatePurchaseOrder(Guid PurchaseOrderID,PurchaseOrder PurchaseOrder)
        {
            PurchaseOrderRepository.Update(PurchaseOrderID, PurchaseOrder);
        }
    }
}

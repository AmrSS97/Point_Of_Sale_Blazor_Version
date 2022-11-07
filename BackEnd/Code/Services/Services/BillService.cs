using Data.Infrastructure;
using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class BillService : IBillService
    {
        private readonly IBillRepository BillRepository;
        private readonly IUnitOfWork UnitOfWork;

        public BillService(IBillRepository BillRepository, IUnitOfWork UnitOfWork)
        {
            this.BillRepository = BillRepository;
            this.UnitOfWork = UnitOfWork;
        }
        public void CreateBill(Bill Bill)
        {
            BillRepository.Add(Bill);
        }

        public void DeleteBill(Bill Bill)
        {
            BillRepository.Delete(Bill);
        }

        public Bill GetBillByID(Guid BillID)
        {
            return BillRepository.GetById(BillID);
        }

        public BillDTO GetBillDtoByID(Guid BillID)
        {
            return BillRepository.GetBillDtoByID(BillID);
        }

        public List<BillDTO> GetBillDtoList()
        {
            return BillRepository.GetBillDtolist();
        }

        public void SaveBill()
        {
            UnitOfWork.Commit();
        }

        public BillDTO SoftDeleteBill(Guid BillID)
        {
            Bill BillObj = GetBillByID(BillID);
            BillDTO BillDto = GetBillDtoByID(BillID);
            BillObj.IsDeleted = true;
            UpdateBill(BillID, BillObj);
            SaveBill();

            return BillDto;
        }

        public void UpdateBill(Guid BillID, Bill Bill)
        {
            BillRepository.Update(BillID, Bill);
        }
    }
}

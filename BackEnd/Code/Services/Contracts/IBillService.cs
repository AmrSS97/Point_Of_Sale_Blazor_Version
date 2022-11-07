using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IBillService
    {
        void CreateBill(Bill Bill);
        void DeleteBill(Bill Bill);
        void UpdateBill(Guid BillID, Bill Bill);
        void SaveBill();
        BillDTO SoftDeleteBill(Guid BillID);
        Bill GetBillByID(Guid BillID);
        List<BillDTO> GetBillDtoList();
        BillDTO GetBillDtoByID(Guid BillID);
    }
}

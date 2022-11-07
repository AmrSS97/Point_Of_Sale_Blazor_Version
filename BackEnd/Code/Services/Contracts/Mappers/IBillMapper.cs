using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IBillMapper
    {
        public Bill MapBillDtoToBill(BillDTO BillDto);
        public Bill MapBillDtoToBill(Bill BillObj, BillDTO BillDto);
    }
}

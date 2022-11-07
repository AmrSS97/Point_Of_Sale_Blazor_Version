using Data.Infrastructure;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface IBillRepository : IRepository<Bill>
    {
        List<BillDTO> GetBillDtolist();
        BillDTO GetBillDtoByID(Guid BillID);
    }
}

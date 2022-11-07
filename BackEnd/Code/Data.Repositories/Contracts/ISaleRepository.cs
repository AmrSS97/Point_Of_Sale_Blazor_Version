using Data.Infrastructure;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface ISaleRepository : IRepository<Sale>
    {
        List<SaleDTO> GetSaleDtoList();
        List<Sale> GetSalesByBillID(Guid BillID);
        SaleDTO GetSaleDtoByID(Guid SaleID);
    }
}

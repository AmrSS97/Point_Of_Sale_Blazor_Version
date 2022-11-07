using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISaleService
    {
        void CreateSale(Sale Sale);
        void DeleteSale(Sale Sale);
        SaleDTO SoftDeleteSale(Guid SaleID);
        void UpdateSale(Guid SaleID,Sale Sale);
        void SaveSale();
        List<SaleDTO> GetSaleDtoList();
        void AddSales(List<Item> ItemList, DateTime BillDate);
        Sale GetSaleByID(Guid SaleID);
        SaleDTO GetSaleDtoByID(Guid SaleID);
        void DeleteSalesDueToRefund(Guid BillID);
    }
}

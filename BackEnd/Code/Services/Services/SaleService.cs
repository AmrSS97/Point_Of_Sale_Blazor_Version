using Data.Infrastructure;
using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository SaleRepository;
        private readonly IUnitOfWork UnitOfWork;

        public SaleService(ISaleRepository SaleRepository, IUnitOfWork UnitOfWork)
        {
            this.SaleRepository = SaleRepository;
            this.UnitOfWork = UnitOfWork;
        }

        public void AddSales(List<Item> ItemList, DateTime BillDate)
        {
            foreach(Item Item in ItemList)
            {
                Sale Sale = new Sale();
                Sale.BillID = Item.BillID;
                Sale.ProductID = Item.ProductID;
                Sale.SoldQuantity = Item.ItemQuantity;
                Sale.SaleDate = BillDate;
                Sale.IsDeleted = false;
                CreateSale(Sale);
                SaveSale();
            }
        }

        public void CreateSale(Sale Sale)
        {
            SaleRepository.Add(Sale);
        }

        public void DeleteSale(Sale Sale)
        {
            SaleRepository.Delete(Sale);
        }

        public void DeleteSalesDueToRefund(Guid BillID)
        {
            List<Sale> Sales = SaleRepository.GetSalesByBillID(BillID);
            foreach(Sale Sale in Sales)
            {
                Sale.IsDeleted = true;
                UpdateSale(Sale.SaleID,Sale);
                SaveSale();
            }
        }

        public Sale GetSaleByID(Guid SaleID)
        {
            return SaleRepository.GetById(SaleID);
        }

        public SaleDTO GetSaleDtoByID(Guid SaleID)
        {
            return SaleRepository.GetSaleDtoByID(SaleID);
        }

        public List<SaleDTO> GetSaleDtoList()
        {
            return SaleRepository.GetSaleDtoList();
        }

        public void SaveSale()
        {
            UnitOfWork.Commit();
        }

        public SaleDTO SoftDeleteSale(Guid SaleID)
        {
            Sale SaleObj = GetSaleByID(SaleID);
            SaleDTO SaleDto = GetSaleDtoByID(SaleID);
            SaleObj.IsDeleted = true;
            UpdateSale(SaleID, SaleObj);
            SaveSale();

            return SaleDto;
        }

        public void UpdateSale(Guid SaleID,Sale Sale)
        {
            SaleRepository.Update(SaleID, Sale);
        }

    }
}

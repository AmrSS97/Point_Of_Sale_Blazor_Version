using Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class SaleRepository : BaseRepository<Sale>,ISaleRepository
    {
        public SaleRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
         : base(dbFactory, securityHelper) { }

        public SaleDTO GetSaleDtoByID(Guid SaleID)
        {
            return DbContext.Sales.Include(s => s.Product).Where(s => s.SaleID == SaleID).Select(s => new SaleDTO { 
            SaleID = s.SaleID,
            SaleDate = s.SaleDate,
            SoldQuantity = s.SoldQuantity,
            ProductName = s.Product.ProductName
                })
                .AsNoTracking()
                .FirstOrDefault();
        }

        public List<SaleDTO> GetSaleDtoList()
        {
            return DbContext.Sales.Where(s => s.IsDeleted == false).Include(s => s.Product).Select(s => new SaleDTO
            {
                SaleID = s.SaleID,
                SaleDate = s.SaleDate,
                SoldQuantity = s.SoldQuantity,
                ProductName = s.Product.ProductName,
                ProductPrice = s.Product.Price
            }).AsNoTracking()
              .ToList();
        }

        public List<Sale> GetSalesByBillID(Guid BillID)
        {
            return DbContext.Sales.Where(s => s.BillID == BillID).AsNoTracking().ToList();
        }
    }
}

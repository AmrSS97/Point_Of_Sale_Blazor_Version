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
    public class BillRepository : BaseRepository<Bill>,IBillRepository
    {
        public BillRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
          : base(dbFactory, securityHelper) { }

        public BillDTO GetBillDtoByID(Guid BillID)
        {
            return DbContext.Bills.Where(b => b.BillID == BillID).Include(u => u.User).Include(c => c.Customer).Select(b => new BillDTO
            {
                BillID = b.BillID,
                BillDate = b.BillDate,
                CustomerName = b.Customer.FullName,
                UserName = b.User.UserName,
                PaymentType = b.PaymentType,
                TotalValue = b.TotalValue,
                ItemDtoList = b.ItemList.Select(i => new ItemDTO { 
                ItemID = i.ItemID,
                ItemQuantity = i.ItemQuantity,
                ProductName = i.Product.ProductName
                }).ToList()
            }).AsNoTracking().FirstOrDefault();
        }

        public List<BillDTO> GetBillDtolist()
        {
            return DbContext.Bills.Where(b => b.IsDeleted == false).Include(u => u.User).Include(c => c.Customer).Select(b => new BillDTO
            {
                BillID = b.BillID,
                BillDate = b.BillDate,
                CustomerName = b.Customer.FullName,
                UserName = b.User.UserName,
                PaymentType = b.PaymentType,
                TotalValue = b.TotalValue,
                ItemDtoList = b.ItemList.Select(i => new ItemDTO
                {
                    ItemID = i.ItemID,
                    ItemQuantity = i.ItemQuantity,
                    ProductName = i.Product.ProductName
                }).ToList()
            }).AsNoTracking().ToList();
        }
    }
}

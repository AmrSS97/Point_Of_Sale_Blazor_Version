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
    public class SupplierRepository : BaseRepository<Supplier>,ISupplierRepository
    {
        public SupplierRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
         : base(dbFactory, securityHelper) { }

        public Supplier GetSupplierByPhone(string SupplierPhone)
        {
            return DbContext.Suppliers.Where(s => s.SupplierPhone == SupplierPhone && s.IsDeleted == false).AsNoTracking().FirstOrDefault();
        }

        public SupplierDTO GetSupplierDtoById(Guid SupplierID)
        {
            return DbContext.Suppliers.Where(s => s.SupplierID == SupplierID).Select(s => new SupplierDTO
            {
                SupplierID = s.SupplierID,
                SupplierEmail = s.SupplierEmail,
                SupplierName = s.SupplierName,
                SupplierPhone = s.SupplierPhone
            }).AsNoTracking()
              .FirstOrDefault();
        }

        public List<SupplierDTO> GetSupplierDtoList()
        {
            return DbContext.Suppliers.Where(s => s.IsDeleted == false).Select(s => new SupplierDTO
            {

                SupplierID = s.SupplierID,
                SupplierEmail = s.SupplierEmail,
                SupplierName = s.SupplierName,
                SupplierPhone = s.SupplierPhone
            }).AsNoTracking()
              .ToList();
        }
    }
}

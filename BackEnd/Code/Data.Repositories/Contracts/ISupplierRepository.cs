using Data.Infrastructure;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        List<SupplierDTO> GetSupplierDtoList();
        SupplierDTO GetSupplierDtoById(Guid SupplierID);
        Supplier GetSupplierByPhone(string SupplierPhone);
    }
}

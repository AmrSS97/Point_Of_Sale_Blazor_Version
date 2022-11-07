using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISupplierService
    {
        void CreateSupplier(Supplier Supplier);
        void DeleteSupplier(Supplier Supplier);
        SupplierDTO SoftDeleteSupplier(Guid SupplierID);
        void UpdateSupplier(Guid SupplierID,Supplier Supplier);
        void SaveSupplier();
        List<SupplierDTO> GetSupplierDtoList();
        SupplierDTO GetSupplierDtoByID(Guid SupplierID);
        Supplier GetSupplierByID(Guid SupplierID);
        Supplier GetSupplierByPhone(string SupplierPhone);
        ResultDTO ValidateSupplier(SupplierDTO SupplierDto);
    }
}

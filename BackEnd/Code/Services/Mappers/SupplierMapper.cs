using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class SupplierMapper : ISupplierMapper
    {
        public Supplier MapSupplierDtoToSupplier(SupplierDTO SupplierDto)
        {
            Supplier SupplierObj = new Supplier();
            SupplierObj.SupplierName = SupplierDto.SupplierName;
            SupplierObj.SupplierPhone = SupplierDto.SupplierPhone;
            SupplierObj.SupplierEmail = SupplierDto.SupplierEmail;
            SupplierObj.IsDeleted = false;
            return SupplierObj;
        }

        public Supplier MapSupplierDtoToSupplier(Supplier SupplierObj, SupplierDTO SupplierDto)
        {
            SupplierObj.SupplierName = SupplierDto.SupplierName;
            SupplierObj.SupplierPhone = SupplierDto.SupplierPhone;
            SupplierObj.SupplierEmail = SupplierDto.SupplierEmail;
            return SupplierObj;
        }
    }
}

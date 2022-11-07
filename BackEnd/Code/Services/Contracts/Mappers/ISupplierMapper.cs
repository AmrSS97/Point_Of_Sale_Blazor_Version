using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISupplierMapper
    {
        public Supplier MapSupplierDtoToSupplier(SupplierDTO SupplierDto);
        public Supplier MapSupplierDtoToSupplier(Supplier SupplierObj,SupplierDTO SupplierDto);
    }
}

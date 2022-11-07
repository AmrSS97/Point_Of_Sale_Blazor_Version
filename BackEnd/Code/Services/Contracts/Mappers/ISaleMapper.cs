using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISaleMapper
    {
        public Sale MapSaleDtoToSale(Sale SaleObj, SaleDTO SaleDto);
    }
}

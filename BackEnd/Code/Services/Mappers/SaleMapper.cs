using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class SaleMapper : ISaleMapper
    {
        private readonly IProductService ProductService;
        public SaleMapper(IProductService ProductService)
        {
            this.ProductService = ProductService;
        }
        public Sale MapSaleDtoToSale(Sale SaleObj, SaleDTO SaleDto)
        {
            SaleObj.SoldQuantity = SaleDto.SoldQuantity;
            SaleObj.SaleDate = SaleDto.SaleDate;
            SaleObj.ProductID = ProductService.GetProductByName(SaleDto.ProductName).ProductID;

            return SaleObj;
        }
    }
}

using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IProductMapper
    {
        public Product MapProductDtoToProduct(ProductDTO ProductDto);
        public Product MapProductDtoToProduct(Product ProductObj, ProductDTO ProductDto);
    }
}

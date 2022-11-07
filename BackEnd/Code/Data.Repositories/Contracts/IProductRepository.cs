using Data.Infrastructure;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        List<ProductDTO> GetProductDtoList();
        ProductDTO GetProductDtoByID(Guid ProductID);
        Product GetProductByName(string ProductName);
    }
}

using Data.Infrastructure;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        List<CustomerDTO> GetCustomerDtoList();
        CustomerDTO GetCustomerDtoByID(Guid CustomerID);
        Customer GetCustomerByPhone(string CustomerPhone);
    }
}

using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ICustomerService
    {
        void CreateCustomer(Customer Customer);
        void DeleteCustomer(Customer Customer);
        void UpdateCustomer(Guid CustomerID,Customer Customer);
        CustomerDTO SoftDeleteCustomer(Guid CustomerID);
        void SaveCustomer();
        List<CustomerDTO> GetCustomerDtoList();
        CustomerDTO GetCustomerDtoByID(Guid CustomerID);
        Customer GetCustomerByID(Guid CustomerID);
        Customer GetCustomerByPhone(string CustomerPhone);
        ResultDTO ValidateCustomer(CustomerDTO CustomerDto);
    }
}

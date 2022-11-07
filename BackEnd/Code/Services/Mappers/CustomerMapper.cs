using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CustomerMapper : ICustomerMapper
    {
        public Customer MapCustomerDtoToCustomer(CustomerDTO CustomerDto)
        {
            Customer CustomerObj = new Customer();
            CustomerObj.FullName = CustomerDto.FullName;
            CustomerObj.CustomerPhone = CustomerDto.CustomerPhone;
            CustomerObj.CustomerEmail = CustomerDto.CustomerEmail;
            CustomerObj.CustomerAddress = CustomerDto.CustomerAddress;
            CustomerObj.IsDeleted = false;
            return CustomerObj;
        }

        public Customer MapCustomerDtoToCustomer(Customer CustomerObj, CustomerDTO CustomerDto)
        {
            CustomerObj.FullName = CustomerDto.FullName;
            CustomerObj.CustomerPhone = CustomerDto.CustomerPhone;
            CustomerObj.CustomerEmail = CustomerDto.CustomerEmail;
            CustomerObj.CustomerAddress = CustomerDto.CustomerAddress;
            return CustomerObj;
        }
    }
}

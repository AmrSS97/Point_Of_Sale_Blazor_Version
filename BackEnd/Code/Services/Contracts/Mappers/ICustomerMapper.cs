using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ICustomerMapper
    {
        public Customer MapCustomerDtoToCustomer(CustomerDTO CustomerDto);
        public Customer MapCustomerDtoToCustomer(Customer Customer,CustomerDTO CustomerDto);
    }
}

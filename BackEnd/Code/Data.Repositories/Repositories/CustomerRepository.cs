using Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
         : base(dbFactory, securityHelper) { }

        public Customer GetCustomerByPhone(string CustomerPhone)
        {
            return DbContext.Customers.Where(c => c.CustomerPhone == CustomerPhone && c.IsDeleted == false).AsNoTracking().FirstOrDefault();

        }

        public CustomerDTO GetCustomerDtoByID(Guid CustomerID)
        {
            return DbContext.Customers.Where(c => c.CustomerID == CustomerID).Select(c => new CustomerDTO
            {
                CustomerID = c.CustomerID,
                CustomerAddress = c.CustomerAddress,
                CustomerEmail = c.CustomerEmail,
                CustomerPhone = c.CustomerPhone,
                FullName = c.FullName
            }).AsNoTracking()
              .FirstOrDefault();
        }

        public List<CustomerDTO> GetCustomerDtoList()
        {
            return DbContext.Customers.Where(c => c.IsDeleted == false).Select(c => new CustomerDTO
            {
                CustomerID = c.CustomerID,
                CustomerEmail = c.CustomerEmail,
                CustomerAddress = c.CustomerAddress,
                CustomerPhone = c.CustomerPhone,
                FullName = c.FullName

            }).AsNoTracking()
             .ToList();
        }
    }
}

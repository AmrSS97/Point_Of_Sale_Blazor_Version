using Data.Infrastructure;
using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository CustomerRepository;
        private readonly IUnitOfWork UnitOfWork;

        public CustomerService(ICustomerRepository CustomerRepository, IUnitOfWork UnitOfWork)
        {
            this.CustomerRepository = CustomerRepository;
            this.UnitOfWork = UnitOfWork;
        }
        public void CreateCustomer(Customer Customer)
        {
            CustomerRepository.Add(Customer);
        }

        public void DeleteCustomer(Customer Customer)
        {
            CustomerRepository.Delete(Customer);
        }

        public Customer GetCustomerByID(Guid CustomerID)
        {
            return CustomerRepository.GetById(CustomerID);
        }

        public Customer GetCustomerByPhone(string CustomerPhone)
        {
            return CustomerRepository.GetCustomerByPhone(CustomerPhone);
        }

        public CustomerDTO GetCustomerDtoByID(Guid CustomerID)
        {
            return CustomerRepository.GetCustomerDtoByID(CustomerID);
        }

        public List<CustomerDTO> GetCustomerDtoList()
        {
            return CustomerRepository.GetCustomerDtoList();
        }

        public void SaveCustomer()
        {
            UnitOfWork.Commit();
        }

        public void UpdateCustomer(Guid CustomerID, Customer Customer)
        {
            CustomerRepository.Update(CustomerID, Customer);
        }

        public ResultDTO ValidateCustomer(CustomerDTO CustomerDto)
        {
            ResultDTO result = new ResultDTO();
            ErrorDTO error = new ErrorDTO();
            Customer ValidateCustomer = GetCustomerByPhone(CustomerDto.CustomerPhone);
            if(CustomerDto.CustomerID == Guid.Empty && ValidateCustomer != null)
            {
                error.ErrorMessageEN = "Customer Already Exists !";
                result.Errors.Add(error);
                return result;
            }
            if(CustomerDto.CustomerID != Guid.Empty && CustomerDto.CustomerID != ValidateCustomer.CustomerID)
            {
                error.ErrorMessageEN = "Customer Already Exists !";
                result.Errors.Add(error);
                return result;
            }

            return result;
        }

        public CustomerDTO SoftDeleteCustomer(Guid CustomerID)
        {
            Customer CustomerObj = GetCustomerByID(CustomerID);
            CustomerDTO CustomerDto = GetCustomerDtoByID(CustomerID);
            CustomerObj.IsDeleted = true;
            UpdateCustomer(CustomerID,CustomerObj);
            SaveCustomer();

            return CustomerDto;
        }
    }
}

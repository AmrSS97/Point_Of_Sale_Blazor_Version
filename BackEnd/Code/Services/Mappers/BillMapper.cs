using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class BillMapper : IBillMapper
    {
        private readonly IUserService UserService;
        private readonly ICustomerService CustomerService;
        public BillMapper(IUserService UserService, ICustomerService CustomerService)
        {
            this.UserService = UserService;
            this.CustomerService = CustomerService;
        }
        public Bill MapBillDtoToBill(BillDTO BillDto)
        {
            Bill BillObj = new Bill();
            BillObj.BillDate = BillDto.BillDate;
            BillObj.TotalValue = BillDto.TotalValue;
            BillObj.PaymentType = BillDto.PaymentType;
            BillObj.UserID = UserService.GetUserByUserName(BillDto.UserName).UserID;
            BillObj.CustomerID = CustomerService.GetCustomerByPhone(BillDto.CustomerPhone).CustomerID;
            BillObj.IsDeleted = false;

            return BillObj;
        }

        public Bill MapBillDtoToBill(Bill BillObj, BillDTO BillDto)
        {
            BillObj.BillDate = BillDto.BillDate;
            BillObj.TotalValue = BillDto.TotalValue;
            BillObj.PaymentType = BillDto.PaymentType;
            BillObj.UserID = UserService.GetUserByUserName(BillDto.UserName).UserID;
            BillObj.CustomerID = CustomerService.GetCustomerByPhone(BillDto.CustomerPhone).CustomerID;

            return BillObj;
        }
    }
}

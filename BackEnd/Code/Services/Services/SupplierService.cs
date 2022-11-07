using Data.Infrastructure;
using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository SupplierRepository;
        private readonly IUnitOfWork UnitOfWork;

        public SupplierService(ISupplierRepository SupplierRepository, IUnitOfWork UnitOfWork)
        {
            this.SupplierRepository = SupplierRepository;
            this.UnitOfWork = UnitOfWork;
        }
        public void CreateSupplier(Supplier Supplier)
        {
            SupplierRepository.Add(Supplier);
        }

        public void DeleteSupplier(Supplier Supplier)
        {
            SupplierRepository.Delete(Supplier);
        }

        public Supplier GetSupplierByPhone(string SupplierPhone)
        {
            return SupplierRepository.GetSupplierByPhone(SupplierPhone);
        }

        public Supplier GetSupplierByID(Guid SupplierID)
        {
            return SupplierRepository.GetById(SupplierID);
        }

        public SupplierDTO GetSupplierDtoByID(Guid SupplierID)
        {
            return SupplierRepository.GetSupplierDtoById(SupplierID);
        }

        public List<SupplierDTO> GetSupplierDtoList()
        {
            return SupplierRepository.GetSupplierDtoList();
        }

        public void SaveSupplier()
        {
            UnitOfWork.Commit();
        }

        public SupplierDTO SoftDeleteSupplier(Guid SupplierID)
        {
            Supplier SupplierObj = GetSupplierByID(SupplierID);
            SupplierDTO SupplierDto = GetSupplierDtoByID(SupplierID);
            SupplierObj.IsDeleted = true;
            UpdateSupplier(SupplierID, SupplierObj);
            SaveSupplier();

            return SupplierDto;
        }

        public void UpdateSupplier(Guid SupplierID, Supplier Supplier)
        {
            SupplierRepository.Update(SupplierID,Supplier);
        }

        public ResultDTO ValidateSupplier(SupplierDTO SupplierDto)
        {
            ResultDTO result = new ResultDTO();
            ErrorDTO error = new ErrorDTO();
            Supplier ValidateSupplier = GetSupplierByPhone(SupplierDto.SupplierPhone);
            if(SupplierDto.SupplierID == Guid.Empty && ValidateSupplier != null)
            {
                error.ErrorMessageEN = "Supplier Already Exists";
                result.Errors.Add(error);
                return result;
            }
            if(SupplierDto.SupplierID != Guid.Empty && SupplierDto.SupplierID != ValidateSupplier.SupplierID)
            {
                error.ErrorMessageEN = "Supplier Already Exists";
                result.Errors.Add(error);
                return result;
            }

            return result;
        }
    }
}

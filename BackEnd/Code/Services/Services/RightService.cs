using Data.Infrastructure;
using Data.Repositories;
using Models;
using System;

namespace Services
{

    public class RightService : IRightService
    {
        private readonly IRightRepository RightRepository;
        private readonly IUnitOfWork unitOfWork;

        public RightService(IRightRepository RightRepository, IUnitOfWork unitOfWork)
        {
            this.RightRepository = RightRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IApplicationService Members


        public Right GetRight(Guid id)
        {
            var Right = RightRepository.GetById(id);
            return Right;
        }

        public void CreateRight(Right Right)
        {
            RightRepository.Add(Right);
        }

        public void SaveRight()
        {
            unitOfWork.Commit();
        }

   

        #endregion
    }
}

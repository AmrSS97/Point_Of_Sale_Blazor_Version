using Data.Infrastructure;
using Data.Repositories;
using Models;
using System;

namespace Services
{

    public class RoleRightService : IRoleRightService
    {
        private readonly IRoleRightRepository RoleRightRepository;
        private readonly IUnitOfWork unitOfWork;

        public RoleRightService(IRoleRightRepository RoleRightRepository, IUnitOfWork unitOfWork)
        {
            this.RoleRightRepository = RoleRightRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IApplicationService Members


        public RoleRight GetRoleRight(Guid id)
        {
            var RoleRight = RoleRightRepository.GetById(id);
            return RoleRight;
        }

        public void CreateRoleRight(RoleRight RoleRight)
        {
            RoleRightRepository.Add(RoleRight);
        }

        public void SaveRoleRight()
        {
            unitOfWork.Commit();
        }

   

        #endregion
    }
}

using Data.Infrastructure;
using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{

    public class RoleService : IRoleService
    {
        private readonly IRoleRepository RoleRepository;
        private readonly IRoleRightRepository RoleRightRepository;
        private readonly IUnitOfWork unitOfWork;


        public RoleService(IRoleRepository RoleRepository, IRoleRightRepository RoleRightRepository, IUnitOfWork unitOfWork)
        {
            this.RoleRepository = RoleRepository;
            this.RoleRightRepository = RoleRightRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IApplicationService Members

        public List<Role> GetAll()
        {
            List<Role> Roles = RoleRepository.GetAll().ToList();
            return Roles;
        }

        public PagedResult<Role> GetAll(int PageNumber, int PageSize, string SortBy = "", string SortDirection = "")
        {
            List<string> Includes = new List<string>();
            Models.DTO.PagedResult<Role> Roles = RoleRepository.GetAll(PageNumber, PageSize, Includes, SortBy, SortDirection);
            return Roles;
        }

        public Role GetRole(Guid id)
        {
            var Role = RoleRepository.GetById(id);
            return Role;
        }

        public void CreateRole(Role Role)
        {
            RoleRepository.Add(Role);
        }

        public void UpdateRole(Role role)
        {
            RoleRightRepository.Delete(item => item.RoleID == role.RoleID);

            // add new roleRights
            foreach (RoleRight item in role.RoleRights)
            {
                RoleRight roleRight = new RoleRight();
                roleRight.RoleID = role.RoleID;
                roleRight.RightID = item.RightID;
                RoleRightRepository.Add(roleRight);
            }
            role.RoleRights = null;
            RoleRepository.Update(role.RoleID, role);

        }

        public void DeleteRole(Role role)
        {
            RoleRepository.Delete(role);
        }

        public void GetFeaturesRights(Role role)
        {
            RoleRepository.Delete(role);
        }

        

        public void SaveRole()
        {
            unitOfWork.Commit();
        }

        public void BulkInsert(List<Role> roles)
        {
            RoleRepository.BulkInsert(roles);
        }


        #endregion

        #region Custom Methods
        public object getRoleSideMenu(Guid RoleId)
        {
            return this.RoleRepository.getRoleSideMenu(RoleId);
        }
        public object getFeaturesRights()
        {
            return this.RoleRepository.getFeaturesRights();
        }

        public bool canAccess(Guid role_id, Guid right_id)
        {
            return this.RoleRepository.canAccess(role_id, right_id);
        }

        public bool canAccess(Guid role_id, List<Guid> _rights)
        {
            return this.RoleRepository.canAccess(role_id, _rights);
        }
        public PagedResult<Role> GetAll(FilterModel<Role> FilterObject)
        {
            FilterObject.Includes = new List<string>();
            return RoleRepository.GetAll(FilterObject);
        }
        #endregion
    }
}

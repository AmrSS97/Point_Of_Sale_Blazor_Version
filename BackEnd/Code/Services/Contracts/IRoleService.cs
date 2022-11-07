using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;


namespace Services
{

    public interface IRoleService
    {
        List<Role> GetAll();
        PagedResult<Role> GetAll(int PageNumber, int PageSize, string SortBy,string SortDirection);
        Role GetRole(Guid id);
        void CreateRole(Role Role);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
        void SaveRole();

        //custom methods
        object getRoleSideMenu(Guid RoleId);
        object getFeaturesRights();
        bool canAccess(Guid role_id, Guid right_id);
        bool canAccess(Guid role_id, List<Guid> _rights);
        PagedResult<Role> GetAll(FilterModel<Role> FilterObject);
        void BulkInsert(List<Role> roles);
    }
}

using Data.Infrastructure;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;

namespace Data.Repositories
{

    public interface IRoleRepository : IRepository<Role>
    {
        object getRoleSideMenu(Guid RoleId);
        object getFeaturesRights();
        bool canAccess(Guid role_id, Guid right_id);
        bool canAccess(Guid role_id, List<Guid> rights);
        PagedResult<Role> GetAll(FilterModel<Role> FilterObject);
        void BulkInsert(List<Role> roles);
    }


}

using Data.Repositories;
using Models;
using System;

namespace Services
{

    public interface IRoleRightService
    {
        RoleRight GetRoleRight(Guid id);
        void CreateRoleRight(RoleRight RoleRight);
        void SaveRoleRight();
    }

}

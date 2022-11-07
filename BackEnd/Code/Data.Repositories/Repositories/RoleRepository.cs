using Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Data.Repositories
{

    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
            : base(dbFactory, securityHelper) { }

        public override Role GetById(Guid id)
        {
            return DbContext.Roles.Include(r=>r.RoleRights).ThenInclude(rr=>rr.Right).AsNoTracking().SingleOrDefault(r => r.RoleID == id);
        }

        public object getRoleSideMenu(Guid RoleId)
        {
            return this.DbContext.Features
                .Where(f => f.Rights.Any(r => r.RoleRights.Any(rr => rr.RoleID == RoleId))).AsNoTracking()
                .Select(f => new
                {
                    f.FeatureName,
                    f.FeatureNameAr,
                    f.MenuIcon,
                    Rights = f.Rights.Where(r =>r.RoleRights.Any(rr => rr.RoleID == RoleId))
                        .Select(right => new { right.RightID, right.RightName, right.RightNameAr,right.RightCode ,right.RightOrder,right.MenuIcon,right.RightURL })
                        .OrderBy(rightOrder => rightOrder.RightOrder)
                });
        }

        public object getFeaturesRights()
        {
            return this.DbContext.Features
                .Include(f=>f.Rights).AsNoTracking().ToList();
        }

        public bool canAccess(Guid role_id, Guid right_id)
        {
            return this.DbContext.RoleRights.
                    Include(rr=>rr.Role).
                    Include(rr=>rr.Right).
                    Where(a => a.RoleID == role_id
                       && a.RightID == right_id).AsNoTracking().Count() > 0;
        }

        public bool canAccess(Guid role_id, List<Guid> rights)
        {
            return this.DbContext.RoleRights.
                    Include(rr => rr.Role).
                    Include(rr => rr.Right).
                    Where(a => a.RoleID == role_id
                       && rights.Contains(a.RightID)).AsNoTracking().Count() > 0;
        }
        public PagedResult<Role> GetAll(FilterModel<Role> FilterObject)
        {
            PagedResult<Role> RoleList = new PagedResult<Role>();
            Expression<Func<Role, bool>> SearchCriteria = r => (r.RoleName.Contains(FilterObject.SearchObject.RoleName) || string.IsNullOrEmpty(FilterObject.SearchObject.RoleName));
            RoleList = this.GetAll(FilterObject.PageNumber, FilterObject.PageSize, FilterObject.Includes, SearchCriteria, FilterObject.SortBy, FilterObject.SortDirection);
            return RoleList;
        }
        public void BulkInsert(List<Role> roles)
        {
            DbContext.BulkInsert(roles);
        }

    }


}

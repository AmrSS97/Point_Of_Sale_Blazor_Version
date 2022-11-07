using Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{


    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
            : base(dbFactory, securityHelper) { }

        public override IEnumerable<User> GetAll()
        {
           return DbContext.Users.Include(u=>u.Role).AsNoTracking();
        }

        public User UserLogin(string username, string password)
        {
            return this.DbContext.Users.Where(u => u.UserName == username.ToLower()).Where(c => c.UserPassword == password).AsNoTracking().FirstOrDefault();
        }

        public Models.DTO.PagedResult<User> GetAll(FilterModel<User> FilterObject)
        {
            Models.DTO.PagedResult<User> UserList = new Models.DTO.PagedResult<User>();
            Expression<Func<User, bool>> SearchCriteria = a => (

            (a.UserName.Contains(FilterObject.SearchObject.UserName) || string.IsNullOrEmpty(FilterObject.SearchObject.UserName))
            &&
            (a.FullName.Contains(FilterObject.SearchObject.FullName) || string.IsNullOrEmpty(FilterObject.SearchObject.FullName))
            &&
            (a.RoleID == FilterObject.SearchObject.RoleID || FilterObject.SearchObject.RoleID == Guid.Empty)

            );
            UserList = this.GetAll(FilterObject.PageNumber, FilterObject.PageSize, FilterObject.Includes, SearchCriteria, FilterObject.SortBy, FilterObject.SortDirection);
            return UserList;
        }

        public User GetUserByUserName(string UserName)
        {
            return DbContext.Users.Where(u => u.UserName == UserName).AsNoTracking().FirstOrDefault();
        }

        public List<UserDTO> GetUserDtoList()
        {
            throw new NotImplementedException();
        }
    }


}

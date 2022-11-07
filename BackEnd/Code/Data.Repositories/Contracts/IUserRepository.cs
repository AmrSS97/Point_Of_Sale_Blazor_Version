using Data.Infrastructure;
using Models;
using Models.DTO;
using System.Collections.Generic;

namespace Data.Repositories
{

    public interface IUserRepository : IRepository<User>
    {
        User UserLogin(string username, string password);
        PagedResult<User> GetAll(FilterModel<User> FilterObject);
        User GetUserByUserName(string UserName);
        List<UserDTO> GetUserDtoList();

    }


}

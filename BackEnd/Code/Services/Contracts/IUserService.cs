using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;


namespace Services
{

    public interface IUserService
    {
        List<User> GetAll();
        PagedResult<User> GetAll(int PageNumber, int PageSize, string SortBy, string SortDirection);
        User GetUser(Guid id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        void SaveUser();
        User UserLogin(string username, string password);
        User GetUserByUserName(string UserName);
        PagedResult<User> GetAll(FilterModel<User> FilterObject);
    }
}

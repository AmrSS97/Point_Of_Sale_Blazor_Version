using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // Marks an entity as new
        T Add(T entity);
        // Marks an entity as modified
        void Update(Guid id, T entity);
        // Marks an entity to be removed
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        // Get an entity by int id
        T GetById(Guid id);
        // Get an entity using delegate
        T Get(Expression<Func<T, bool>> where);
        // Gets all entities of type T
        IEnumerable<T> GetAll();
        //Gets all entities with paging with type T
        Models.DTO.PagedResult<T> GetAll(int PageNumber, int PageSize, List<string> includes, string SortBy, string SortDirection);
        //Gets Filtered Entities with paging and sorting
        Models.DTO.PagedResult<T> GetAll(int PageNumber, int PageSize, List<string> includes, Expression<Func<T, bool>> filter = null, string SortBy = "", string SortDirection = "");
        // Gets entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        //Gets a DTO by id
        T GetDtoById(Guid id);
    }
}

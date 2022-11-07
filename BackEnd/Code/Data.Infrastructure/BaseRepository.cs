using Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Data.Infrastructure
{
    public abstract class BaseRepository<T> where T : Models.BaseModel
    {
        #region Properties
        private DBEntities dataContext;
        private readonly DbSet<T> dbSet;
        private readonly SecurityHelper _security;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected DBEntities DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        #endregion

        protected BaseRepository(IDbFactory dbFactory, SecurityHelper securityHelper)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
            _security = securityHelper;
        }

        #region Implementation
        public virtual T Add(T entity)
        {
            entity.CreatedBy = _security.getUserIDFromToken();
            entity.CreationDate = DateTime.Now;
            entity.ModificationDate = DateTime.Now;
            entity.ModifiedBy = _security.getUserIDFromToken();
            Guid? CompanyID = _security.getCompanyIDFromToken();
            if (CompanyID.HasValue && CompanyID != Guid.Empty)
            {
                entity.AssociatedCompanyID = CompanyID.Value;
            }
            return dbSet.Add(entity).Entity;
        }

        public virtual void Update(Guid id, T entity)
        {
            var local = dbSet.Find(id);
            if (local != null)
            {
                dataContext.Entry(local).State = EntityState.Detached;
            }
            entity.ModificationDate = DateTime.Now;
            entity.ModifiedBy = _security.getUserIDFromToken();
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T GetById(Guid id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.AsNoTracking().ToList();
        }

        public virtual T GetDtoById(Guid id)
        {
            return dbSet.Find(id);
        }

        public virtual Models.DTO.PagedResult<T> GetAll(int PageNumber, int PageSize, List<string> includes, string SortBy = "", string SortDirection = "")
        {
            Models.DTO.PagedResult<T> PagedList = new Models.DTO.PagedResult<T>();
            IQueryable<T> Query = dbSet.AsQueryable<T>();
            foreach (string include in includes)
            {
                Query = Query.Include(include);
            }

            string SortByParam = "CreationDate";
            string SortDirectionParam = "ASC";

            if (!string.IsNullOrEmpty(SortBy))
            {
                SortByParam = SortBy;
            }
            if (!string.IsNullOrEmpty(SortDirection))
            {
                SortDirectionParam = SortDirection;
            }


            Expression parent = GetParentEntity<T>(SortByParam);
            Type typeToConvertTo = parent.Type;

            Query = BuilSortingQuery(Query, SortByParam, SortDirectionParam, typeToConvertTo);

            Query = Query.Take(PageSize);

            PagedList.Results = Query.Skip((PageNumber - 1) * PageSize).AsNoTracking().ToList();
            PagedList.TotalRecords = dbSet.Count();
            return PagedList;
        }
        //DTOS



        public virtual Models.DTO.PagedResult<T> GetAll(int PageNumber, int PageSize, List<string> includes, Expression<Func<T, bool>> filter = null, string SortBy = "", string SortDirection = "")
        {
            Models.DTO.PagedResult<T> PagedList = new Models.DTO.PagedResult<T>();
            IQueryable<T> Query = dbSet.AsQueryable<T>();
            foreach (string include in includes)
            {
                Query = Query.Include(include);
            }

            string SortByParam = "CreationDate";
            string SortDirectionParam = "ASC";

            if (!string.IsNullOrEmpty(SortBy))
            {
                SortByParam = SortBy;
            }
            if (!string.IsNullOrEmpty(SortDirection))
            {
                SortDirectionParam = SortDirection;
            }
            if (filter != null)
            {
                Query = Query.Where(filter);

                PagedList.TotalRecords = Query.AsNoTracking().ToList().Count();

            }
            else
            {
                PagedList.TotalRecords = dbSet.Count();
            }
            Expression parent = GetParentEntity<T>(SortByParam);
            Type typeToConvertTo = parent.Type;

            Query = BuilSortingQuery(Query, SortByParam, SortDirectionParam, typeToConvertTo);

            Query = Query.Skip((PageNumber - 1) * PageSize);

            PagedList.Results = Query.Take(PageSize).AsNoTracking().ToList();
            // PagedList.TotalRecords = dbSet.Count();
            return PagedList;
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).AsNoTracking().ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).AsNoTracking().FirstOrDefault<T>();
        }


        #endregion

        #region Sorting Generic Query
        private IQueryable<T> BuilSortingQuery(IQueryable<T> Query, string SortByParam, string SortDirectionParam, Type typeToConvertTo)
        {
            switch (Type.GetTypeCode(typeToConvertTo))
            {
                case TypeCode.Int32:
                    if (SortDirectionParam == "ASC")
                    {
                        Query = Query.OrderBy(GetExpression<T, int>(SortByParam));
                    }
                    else
                    {
                        Query = Query.OrderByDescending(GetExpression<T, int>(SortByParam));
                    }
                    break;
                case TypeCode.Boolean:
                    if (SortDirectionParam == "ASC")
                    {
                        Query = Query.OrderBy(GetExpression<T, bool>(SortByParam));
                    }
                    else
                    {
                        Query = Query.OrderByDescending(GetExpression<T, bool>(SortByParam));
                    }
                    break;
                case TypeCode.Double:
                    if (SortDirectionParam == "ASC")
                    {
                        Query = Query.OrderBy(GetExpression<T, Double>(SortByParam));
                    }
                    else
                    {
                        Query = Query.OrderByDescending(GetExpression<T, Double>(SortByParam));
                    }
                    break;
                case TypeCode.Decimal:
                    if (SortDirectionParam == "ASC")
                    {
                        Query = Query.OrderBy(GetExpression<T, decimal>(SortByParam));
                    }
                    else
                    {
                        Query = Query.OrderByDescending(GetExpression<T, decimal>(SortByParam));
                    }
                    break;
                case TypeCode.DateTime:
                    if (SortDirectionParam == "ASC")
                    {
                        Query = Query.OrderBy(GetExpression<T, DateTime>(SortByParam));
                    }
                    else
                    {
                        Query = Query.OrderByDescending(GetExpression<T, DateTime>(SortByParam));
                    }
                    break;
                case TypeCode.Object://mainly for nullable datetime
                    if (SortDirectionParam == "ASC")
                    {
                        Query = Query.OrderBy(GetExpression<T, DateTime?>(SortByParam));
                    }
                    else
                    {
                        Query = Query.OrderByDescending(GetExpression<T, DateTime?>(SortByParam));
                    }
                    break;
                default:
                    if (SortDirectionParam == "ASC")
                    {
                        Query = Query.OrderBy(GetExpression<T, string>(SortByParam));
                    }
                    else
                    {
                        Query = Query.OrderByDescending(GetExpression<T, string>(SortByParam));
                    }
                    break;
            }
            return Query;
        }

        private Expression<Func<TEntity, TResult>> GetExpression<TEntity, TResult>(string prop)
        {
            var param = Expression.Parameter(typeof(TEntity), "p");
            var parts = prop.Split('.');

            Expression parent = parts.Aggregate<string, Expression>(param, Expression.Property);
            Expression conversion = Expression.Convert(parent, parent.Type);

            return Expression.Lambda<Func<TEntity, TResult>>(conversion, param);

        }

        private Expression GetParentEntity<TEntity>(string prop)
        {
            var param = Expression.Parameter(typeof(TEntity), "p");
            var parts = prop.Split('.');

            Expression parent = parts.Aggregate<string, Expression>(param, Expression.Property);
            return parent;
        }


        #endregion
    }
}

using Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
         : base(dbFactory, securityHelper) { }

        public Category GetCategoryByName(string CategoryName)
        {
            return DbContext.Categories.Where(c => c.CategoryName == CategoryName && c.IsDeleted == false).AsNoTracking().FirstOrDefault();
        }

        public CategoryDTO GetCategoryDtoByID(Guid CategoryID)
        {
            return DbContext.Categories.Include(c => c.Products).Where(c => c.CategoryID == CategoryID && c.IsDeleted == false).Select(c => new CategoryDTO
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName,
                ProductsCount = c.Products.Count()
            }).AsNoTracking()
              .FirstOrDefault();
        }

        public List<CategoryDTO> GetCategoryDtoList()
        {
            return DbContext.Categories.Include(c => c.Products).Where(c => c.IsDeleted == false).Select(c => new CategoryDTO
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName,
                ProductsCount = c.Products.Count()
            }).AsNoTracking()
              .ToList();
        }
    }
}

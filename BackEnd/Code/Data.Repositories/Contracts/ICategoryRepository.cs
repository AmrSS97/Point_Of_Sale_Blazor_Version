using Data.Infrastructure;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<CategoryDTO> GetCategoryDtoList();
        CategoryDTO GetCategoryDtoByID(Guid CategoryID);
        Category GetCategoryByName(string CategoryName);
    }
}

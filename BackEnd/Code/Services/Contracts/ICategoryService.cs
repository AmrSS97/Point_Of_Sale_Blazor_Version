using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ICategoryService
    {
        void CreateCategory(Category Category);
        void UpdateCategory(Guid CategoryID,Category Category);
        void DeleteCategory(Category Category);
        CategoryDTO SoftDeleteCategory(Guid CategoryID);
        void SaveCategory();
        List<CategoryDTO> GetCategoryDtoList();
        CategoryDTO GetCatyegoryDtoByID(Guid CategoryID);
        Category GetCategoryByID(Guid CategoryID);
        Category GetCategoryByName(string CategoryName);
        ResultDTO ValidateCategory(CategoryDTO CategoryDto);
    }
}

using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CategoryMapper : ICategoryMapper
    {
        public Category MapCategoryDtoToCategory(CategoryDTO CategoryDto)
        {
            Category CategoryObj = new Category();
            CategoryObj.CategoryName = CategoryDto.CategoryName;
            CategoryObj.IsDeleted = false;
            return CategoryObj;
        }

        public Category MapCategoryDtoToCategory(Category CategoryObj, CategoryDTO CategoryDto)
        {
            CategoryObj.CategoryName = CategoryDto.CategoryName;
            return CategoryObj;
        }
    }
}

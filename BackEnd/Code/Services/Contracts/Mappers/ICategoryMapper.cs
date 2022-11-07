using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ICategoryMapper
    {
        public Category MapCategoryDtoToCategory(CategoryDTO CategoryDto);
        public Category MapCategoryDtoToCategory(Category CategoryObj , CategoryDTO CategoryDto);
    }
}

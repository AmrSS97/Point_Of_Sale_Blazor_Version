using Data.Infrastructure;
using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository CategoryRepository;
        private readonly IUnitOfWork UnitOfWork;

        public CategoryService(ICategoryRepository CategoryRepository, IUnitOfWork UnitOfWork)
        {
            this.CategoryRepository = CategoryRepository;
            this.UnitOfWork = UnitOfWork;
        }
        public void CreateCategory(Category Category)
        {
            CategoryRepository.Add(Category);
        }

        public void DeleteCategory(Category Category)
        {
            CategoryRepository.Delete(Category);
        }

        public Category GetCategoryByID(Guid CategoryID)
        {
            return CategoryRepository.GetById(CategoryID);
        }

        public Category GetCategoryByName(string CategoryName)
        {
            return CategoryRepository.GetCategoryByName(CategoryName);
        }

        public List<CategoryDTO> GetCategoryDtoList()
        {
            return CategoryRepository.GetCategoryDtoList();
        }

        public CategoryDTO GetCatyegoryDtoByID(Guid CategoryID)
        {
            return CategoryRepository.GetCategoryDtoByID(CategoryID);
        }

        public void SaveCategory()
        {
            UnitOfWork.Commit();
        }

        public CategoryDTO SoftDeleteCategory(Guid CategoryID)
        {
            Category CategoryObj = GetCategoryByID(CategoryID);
            CategoryDTO CategoryDto = GetCatyegoryDtoByID(CategoryID);
            CategoryObj.IsDeleted = true;
            UpdateCategory(CategoryID,CategoryObj);
            SaveCategory();

            return CategoryDto;
        }

        public void UpdateCategory(Guid CategoryID, Category Category)
        {
            CategoryRepository.Update(CategoryID,Category);
        }

        public ResultDTO ValidateCategory(CategoryDTO CategoryDto)
        {
            ResultDTO result = new ResultDTO();
            ErrorDTO error = new ErrorDTO();
            Category ValidateCategory = GetCategoryByName(CategoryDto.CategoryName);
            if(CategoryDto.CategoryID == Guid.Empty && ValidateCategory != null)
            {
                    error.ErrorMessageEN = "Category Already Exists !";
                    result.Errors.Add(error);
                    return result;
            }

            if(CategoryDto.CategoryID != Guid.Empty && CategoryDto.CategoryID != ValidateCategory.CategoryID)
            {
                if (CategoryDto.CategoryName == ValidateCategory.CategoryName)
                {
                    error.ErrorMessageEN = "Category Already Exists !";
                    result.Errors.Add(error);
                    return result;
                }
            }
            return result;
        }
    }
}

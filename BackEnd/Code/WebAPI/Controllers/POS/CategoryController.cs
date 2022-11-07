using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService CategoryService;
        private readonly ICategoryMapper CategoryMapper;

        public CategoryController(ICategoryService CategoryService, ICategoryMapper CategoryMapper)
        {
            this.CategoryService = CategoryService;
            this.CategoryMapper = CategoryMapper;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public List<CategoryDTO> GetCategoryDtoList()
        {
            return CategoryService.GetCategoryDtoList();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{CategoryID}")]
        public IActionResult GetCategoryDtoByID(Guid CategoryID)
        {
            CategoryDTO CategoryDto = CategoryService.GetCatyegoryDtoByID(CategoryID);
            return Ok(CategoryDto);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult PostCategory([FromBody] CategoryDTO CategoryDto)
        {
            ResultDTO result = CategoryService.ValidateCategory(CategoryDto);
            if(result.Errors.Count() == 0)
            { 
            Category CategoryObj = CategoryMapper.MapCategoryDtoToCategory(CategoryDto);
            CategoryService.CreateCategory(CategoryObj);
            CategoryService.SaveCategory();
            CategoryDto.CategoryID = CategoryObj.CategoryID;
            result.Results = CategoryDto;
            return Ok(result);
            }
            return BadRequest(result);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{CategoryID}")]
        public IActionResult PutCategory(Guid CategoryID, [FromBody] CategoryDTO CategoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (CategoryID != CategoryDto.CategoryID)
            {
                return BadRequest();
            }

            ResultDTO result = CategoryService.ValidateCategory(CategoryDto);
            if (result.Errors.Count() == 0) 
            {
            Category CategoryObj = CategoryService.GetCategoryByID(CategoryID);
            CategoryObj = CategoryMapper.MapCategoryDtoToCategory(CategoryObj, CategoryDto);
            CategoryService.UpdateCategory(CategoryID, CategoryObj);
            CategoryService.SaveCategory();

            return StatusCode((int)HttpStatusCode.NoContent);
            }

            return BadRequest(result);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{CategoryID}")]
        public IActionResult DeleteCategory(Guid CategoryID)
        {
            ResultDTO result = new ResultDTO();
            CategoryDTO CategoryDto = CategoryService.SoftDeleteCategory(CategoryID);
            result.Results = CategoryDto;
            return Ok(result);
        }
    }
}

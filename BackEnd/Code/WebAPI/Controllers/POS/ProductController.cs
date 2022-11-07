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
    public class ProductController : ControllerBase
    {
        private readonly IProductService ProductService;
        private readonly IProductMapper ProductMapper;

        public ProductController(IProductService ProductService, IProductMapper ProductMapper)
        {
            this.ProductService = ProductService;
            this.ProductMapper = ProductMapper;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public List<ProductDTO> GetProductDtoList()
        {
            return ProductService.GetProductDtoList();
        }

        // GET api/<ProductController>/5
        [HttpGet("{ProductID}")]
        public IActionResult GetProductDtoByID(Guid ProductID)
        {
            ProductDTO ProductDto = ProductService.GetProductDtoByID(ProductID);
            return Ok(ProductDto);
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult PostProduct([FromBody] ProductDTO ProductDto)
        {
            ResultDTO result = ProductService.ValidateProduct(ProductDto);
            if (result.Errors.Count() == 0)
            {
                Product ProductObj = ProductMapper.MapProductDtoToProduct(ProductDto);
                ProductService.CreateProduct(ProductObj);
                ProductService.SaveProduct();
                ProductDto.ProductID = ProductObj.ProductID;
                result.Results = ProductDto;
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{ProductID}")]
        public IActionResult PutProduct(Guid ProductID, [FromBody] ProductDTO ProductDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (ProductID != ProductDto.ProductID)
            {
                return BadRequest();
            }

            ResultDTO result = ProductService.ValidateProduct(ProductDto);
            if (result.Errors.Count() == 0)
            {
                Product ProductObj = ProductService.GetProductByID(ProductID);
                ProductObj = ProductMapper.MapProductDtoToProduct(ProductObj, ProductDto);
                ProductService.UpdateProduct(ProductID, ProductObj);
                ProductService.SaveProduct();

                return StatusCode((int)HttpStatusCode.NoContent);
            }
            
                return BadRequest(result);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{ProductID}")]
        public IActionResult DeleteProduct(Guid ProductID)
        {
            ResultDTO result = new ResultDTO();
            ProductDTO ProductDto = ProductService.SoftDeleteProduct(ProductID);
            result.Results = ProductDto;
            return Ok(result);

        }
    }
}

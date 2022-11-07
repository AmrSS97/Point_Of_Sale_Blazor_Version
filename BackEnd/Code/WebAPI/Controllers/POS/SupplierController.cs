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
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService SupplierService;
        private readonly ISupplierMapper SupplierMapper;

        public SupplierController(ISupplierService SupplierService, ISupplierMapper SupplierMapper)
        {
            this.SupplierService = SupplierService;
            this.SupplierMapper = SupplierMapper;
        }
        // GET: api/<SupplierController>
        [HttpGet]
        public List<SupplierDTO> GetSupplierDtoList()
        {
            return SupplierService.GetSupplierDtoList();
        }

        // GET api/<SupplierController>/5
        [HttpGet("{SupplierID}")]
        public IActionResult GetSupplierByID(Guid SupplierID)
        {
            SupplierDTO SupplierDto = SupplierService.GetSupplierDtoByID(SupplierID);
            return Ok(SupplierDto);
        }

        // POST api/<SupplierController>
        [HttpPost]
        public IActionResult PostSupplier([FromBody] SupplierDTO SupplierDto)
        {
            ResultDTO result = SupplierService.ValidateSupplier(SupplierDto);
            if (result.Errors.Count() == 0)
            { 
            Supplier SupplierObj = SupplierMapper.MapSupplierDtoToSupplier(SupplierDto);
            SupplierService.CreateSupplier(SupplierObj);
            SupplierService.SaveSupplier();
            SupplierDto.SupplierID = SupplierObj.SupplierID;
            result.Results = SupplierDto;
            return Ok(result);
            }
            return BadRequest(result);

        }

        // PUT api/<SupplierController>/5
        [HttpPut("{SupplierID}")]
        public IActionResult PutSupplier(Guid SupplierID, [FromBody] SupplierDTO SupplierDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (SupplierID != SupplierDto.SupplierID)
            {
                return BadRequest();
            }

            ResultDTO result = SupplierService.ValidateSupplier(SupplierDto);
            if (result.Errors.Count() == 0)
            { 
            Supplier SupplierObj = SupplierService.GetSupplierByID(SupplierID);
            SupplierObj = SupplierMapper.MapSupplierDtoToSupplier(SupplierObj, SupplierDto);
            SupplierService.UpdateSupplier(SupplierID, SupplierObj);
            SupplierService.SaveSupplier();

            return StatusCode((int)HttpStatusCode.NoContent);
            }
            return BadRequest(result);
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{SupplierID}")]
        public IActionResult DeleteSupplier(Guid SupplierID)
        {
            ResultDTO result = new ResultDTO();
            SupplierDTO SupplierDto = SupplierService.SoftDeleteSupplier(SupplierID);
            result.Results = SupplierDto;
            return Ok(result);
        }
    }
}

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
    public class SaleController : ControllerBase
    {
        private readonly ISaleService SaleService;
        private readonly ISaleMapper SaleMapper;

        public SaleController(ISaleService SaleService, ISaleMapper SaleMapper)
        {
            this.SaleService = SaleService;
            this.SaleMapper = SaleMapper;
        }
        // GET: api/<SaleController>
        [HttpGet]
        public List<SaleDTO> GetSaleDtoList()
        {
            return SaleService.GetSaleDtoList();
        }

        // GET api/<SaleController>/5
        [HttpGet("{SaleID}")]
        public IActionResult GetSaleDtoByID(Guid SaleID)
        {
            SaleDTO SaleDto = SaleService.GetSaleDtoByID(SaleID);
            return Ok(SaleDto);
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("{SaleID}")]
        public IActionResult DeleteSale(Guid SaleID)
        {
            ResultDTO result = new ResultDTO();
            SaleDTO SaleDto = SaleService.SoftDeleteSale(SaleID);
            result.Results = SaleDto;
            return Ok(result);
        }

        // PUT api/<SaleController>/5
        /*[HttpPut("{SaleID}")]
        public IActionResult PutSale(Guid SaleID, [FromBody] SaleDTO SaleDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (SaleID != SaleDto.SaleID)
            {
                return BadRequest();
            }
            Sale SaleObj = SaleService.GetSaleByID(SaleID);
            SaleObj = SaleMapper.MapSaleDtoToSale(SaleObj,SaleDto);
            SaleService.UpdateSale(SaleID,SaleObj);
            SaleService.SaveSale();

            return StatusCode((int)HttpStatusCode.NoContent);
        }*/

    }
}

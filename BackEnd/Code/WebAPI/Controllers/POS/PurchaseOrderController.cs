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
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderService PurchaseOrderService;
        private readonly IProductService ProductService;
        private readonly IPurchaseOrderMapper PurchaseOrderMapper;

        public PurchaseOrderController(IPurchaseOrderService PurchaseOrderService, IPurchaseOrderMapper PurchaseOrderMapper, IProductService ProductService)
        {
            this.PurchaseOrderService = PurchaseOrderService;
            this.ProductService = ProductService;
            this.PurchaseOrderMapper = PurchaseOrderMapper;
        }
        // GET: api/<PurchaseOrderController>
        [HttpGet]
        public List<PurchaseOrderDTO> GetPurchaseOrderDtoList()
        {
            return PurchaseOrderService.GetPurchaseOrderDtoList();
        }

        // GET api/<PurchaseOrderController>/5
        [HttpGet("{PurchaseOrderID}")]
        public IActionResult GetPurchaseOrderDtoByID(Guid PurchaseOrderID)
        {
            PurchaseOrderDTO PurchaseOrderDto = PurchaseOrderService.GetPurchaseOderDtoByID(PurchaseOrderID);
            return Ok(PurchaseOrderDto);
        }

        // POST api/<PurchaseOrderController>
        [HttpPost]
        public IActionResult PostPurchaseOrder([FromBody] PurchaseOrderDTO PurchaseOrderDto)
        {
            ResultDTO result = new ResultDTO();
            PurchaseOrder PurchaseOrderObj = PurchaseOrderMapper.MapPurchaseOrderDtoToPurchaseOrder(PurchaseOrderDto);
            PurchaseOrderService.CreatePurchaseOrder(PurchaseOrderObj);
            PurchaseOrderService.SavePurchaseOrder();
            ProductService.UpdateProductStockAfterPurchase(PurchaseOrderObj);
            PurchaseOrderDto.PurchaseOrderID = PurchaseOrderObj.PurchaseOrderID;
            result.Results = PurchaseOrderDto;
            return Ok(result);
        }

        // PUT api/<PurchaseOrderController>/5
        [HttpPut("{PurchaseOrderID}")]
        public IActionResult PutPurchaseOrder(Guid PurchaseOrderID, [FromBody] PurchaseOrderDTO PurchaseOrderDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (PurchaseOrderID != PurchaseOrderDto.PurchaseOrderID)
            {
                return BadRequest();
            }
            PurchaseOrder PurchaseOrderObj = PurchaseOrderService.GetPurchaseOrderByID(PurchaseOrderID);
            PurchaseOrderObj = PurchaseOrderMapper.MapPurchaseOrderDtoToPurchaseOrder(PurchaseOrderObj,PurchaseOrderDto);
            PurchaseOrderService.UpdatePurchaseOrder(PurchaseOrderID,PurchaseOrderObj);
            PurchaseOrderService.SavePurchaseOrder();
            return StatusCode((int)HttpStatusCode.NoContent);
        }

        // DELETE api/<PurchaseOrderController>/5
        [HttpDelete("{PurchaseOrderID}")]
        public IActionResult DeletePurchaseOrder(Guid PurchaseOrderID)
        {
            ResultDTO result = new ResultDTO();
            PurchaseOrder PurchaseOrderObj = PurchaseOrderService.GetPurchaseOrderByID(PurchaseOrderID);
            ProductService.UpdateProductStockBeforeDelete(PurchaseOrderObj);
            PurchaseOrderDTO PurchaseOrderDto = PurchaseOrderService.SoftDeletePurchaseOrder(PurchaseOrderID);
            result.Results = PurchaseOrderDto;
            return Ok(result);
        }
    }
}

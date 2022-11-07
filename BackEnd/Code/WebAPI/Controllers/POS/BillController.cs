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
    public class BillController : ControllerBase
    {
        private readonly IBillService BillService;
        private readonly IItemService ItemService;
        private readonly ISaleService SaleService;
        private readonly IProductService ProductService;
        private readonly IBillMapper BillMapper;
        private readonly IItemMapper ItemMapper;

        public BillController(IBillService BillService, IItemService ItemService, ISaleService SaleService, IProductService ProductService, IBillMapper BillMapper, IItemMapper ItemMapper)
        {
            this.BillService = BillService;
            this.ItemService = ItemService;
            this.SaleService = SaleService;
            this.ProductService = ProductService;
            this.BillMapper = BillMapper;
            this.ItemMapper = ItemMapper;
        }
        // GET: api/<BillController>
        [HttpGet]
        public List<BillDTO> GetBillDtoList()
        {
            return BillService.GetBillDtoList();
        }

        // GET api/<BillController>/5
        [HttpGet("{BillID}")]
        public IActionResult GetBillDtoByID(Guid BillID)
        {
            BillDTO BillDto = BillService.GetBillDtoByID(BillID);
            return Ok(BillDto);
        }

        // POST api/<BillController>
        [HttpPost]
        public IActionResult PostBill([FromBody] BillDTO BillDto)
        {
            ResultDTO result = new ResultDTO();
            Bill BillObj = BillMapper.MapBillDtoToBill(BillDto);
            BillService.CreateBill(BillObj);
            BillService.SaveBill();
            List<Item> ItemList = ItemMapper.MapItemDtoListToItemList(BillDto.ItemDtoList,BillObj.BillID);
            ItemService.AddItemList(ItemList);
            SaleService.AddSales(ItemList,BillDto.BillDate);
            ProductService.UpdateProductStockAfterSale(ItemList);
            BillDto.BillID = BillObj.BillID;
            result.Results = BillDto;
            return Ok(result);
        }


        // PUT api/<BillController>/5
        [HttpPut("{BillID}")]
        public IActionResult PutBill(Guid BillID, [FromBody] BillDTO BillDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (BillID != BillDto.BillID)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        // DELETE api/<BillController>/5
        [HttpDelete("{BillID}")]
        public IActionResult DeleteBill(Guid BillID)
        {
            ResultDTO result = new ResultDTO();
            BillDTO BillDto = BillService.SoftDeleteBill(BillID);
            List<Item> ItemList = ItemMapper.MapItemDtoListToItemList(BillDto.ItemDtoList,BillID);
            SaleService.DeleteSalesDueToRefund(BillID);
            ProductService.UpdateProductStockAfterRefund(ItemList);
            ItemService.DeleteItemsDueToRefund(ItemList);
            result.Results = BillDto;
            return Ok(result);
        }
    }
}

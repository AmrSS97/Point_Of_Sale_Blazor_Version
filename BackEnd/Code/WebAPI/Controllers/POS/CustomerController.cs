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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService CustomerService;
        private readonly ICustomerMapper CustomerMapper;

        public CustomerController(ICustomerService CustomerService,ICustomerMapper CustomerMapper)
        {
            this.CustomerService = CustomerService;
            this.CustomerMapper = CustomerMapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public List<CustomerDTO> GetCustomerDtoList()
        {
            return CustomerService.GetCustomerDtoList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{CustomerID}")]
        public IActionResult GetCustomerDtoByID(Guid CustomerID)
        {
            CustomerDTO CustomerDto = CustomerService.GetCustomerDtoByID(CustomerID);
            return Ok(CustomerDto);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult PostCustomer([FromBody] CustomerDTO CustomerDto)
        {
            ResultDTO result = CustomerService.ValidateCustomer(CustomerDto);
            if(result.Errors.Count() == 0)
            { 
            Customer CustomerObj = CustomerMapper.MapCustomerDtoToCustomer(CustomerDto);
            CustomerService.CreateCustomer(CustomerObj);
            CustomerService.SaveCustomer();
            CustomerDto.CustomerID = CustomerObj.CustomerID;
            result.Results = CustomerDto;
            return Ok(result);
            }
            return BadRequest(result);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{CustomerID}")]
        public IActionResult PutCustomer(Guid CustomerID, [FromBody] CustomerDTO CustomerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (CustomerID != CustomerDto.CustomerID)
            {
                return BadRequest();
            }

            ResultDTO result = CustomerService.ValidateCustomer(CustomerDto);
            if (result.Errors.Count() == 0)
            { 
            Customer CustomerObj = CustomerService.GetCustomerByID(CustomerID);
            CustomerObj = CustomerMapper.MapCustomerDtoToCustomer(CustomerObj, CustomerDto);
            CustomerService.UpdateCustomer(CustomerID, CustomerObj);
            CustomerService.SaveCustomer();

            return StatusCode((int)HttpStatusCode.NoContent);
            }
            return BadRequest(result);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{CustomerID}")]
        public IActionResult DeleteCustomer(Guid CustomerID)
        {
            ResultDTO result = new ResultDTO();
            CustomerDTO CustomerDto = CustomerService.SoftDeleteCustomer(CustomerID);
            result.Results = CustomerDto;
            return Ok(result);
        }
    }
}

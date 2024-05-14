using App.Application.Customer.Commands.CreateCustomer;
using App.Application.Customer.Queries.GetCustomerById;
using App.Application.Customer.Queries.GetCustomers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : APIControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Getallcustomers()
        {
            var customers = await Mediator.Send(new GetCustomersQuery());
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetcustomerbyId(string id)
        {
            var customer = await Mediator.Send(new GetCustomerByIdQuery { Id = id });
            return Ok(customer);
        }

        
    }
}

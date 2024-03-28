using BookWebApi.Application.Features.Customers.Command.CreateCustomer;
using BookWebApi.Application.Features.Customers.Queries.GetAllCustomers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            this._mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpGet]

        public async Task<IActionResult> GetAllCustomers()
        {
            var response = await _mediator.Send(new GetAllCustomersQueryRequest());
            return Ok(response);
        }
    }
}

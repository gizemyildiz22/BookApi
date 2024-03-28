
using BookWebApi.Application.Features.Orders.Command.CreateOrder;
using BookWebApi.Application.Features.Orders.Command.DeleteOrder;
using BookWebApi.Application.Features.Orders.Queries.GetAllOrders;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            this._mediator = mediator;

        }


        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var response = await _mediator.Send(new GetAllOrdersQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteOrder(DeleteOrderCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}

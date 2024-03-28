using BookWebApi.Application.Features.Books.Queries.GetAllBooks;
using BookWebApi.Application.Features.Categories.Queries.GetAllCategories;
using BookWebApi.Application.Features.Customers.Command.CreateCategory;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoriesCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpGet]
       
        public async Task<IActionResult> GetAllCategories()
        {
            var response = await _mediator.Send(new GetAllCategoriesQueryRequest());
            return Ok(response);
        }
    }
}

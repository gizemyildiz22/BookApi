using BookWebApi.Application.Features.Authors.Command.CreateAuthor;
using BookWebApi.Application.Features.Authors.Queries.GetAllAuthors;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        private readonly IMediator _mediator;
        public AuthorController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorsCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpGet]

        public async Task<IActionResult> GetAllAuthors()
        {
            var response = await _mediator.Send(new GetAllAuthorsQueryRequest());
            return Ok(response);
        }

    }
}

using BookWebApi.Application.Features.Books.Command.CreateBook;
using BookWebApi.Application.Features.Books.Command.DeleteBook;
using BookWebApi.Application.Features.Books.Command.UpdateBook;
using BookWebApi.Application.Features.Books.Queries.GetAllBooks;
using BookWebApi.Application.Features.Books.Queries.GetById;
using BookWebApi.Application.Interfaces.UnitOfWorks;
using BookWebApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BookApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator) 
        {
            this._mediator = mediator;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAllBooks()
        {
            var response = await _mediator.Send(new GetAllBooksQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult>CreateBook(CreateBookCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBook(UpdateBookCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBook(DeleteBookCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetByIdQueryRequest(id);
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }


        



    }
}

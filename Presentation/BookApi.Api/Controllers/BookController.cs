using BookApi.Application.Repositories;
using BookApi.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        readonly private IBookWriteRepository _bookWriteRepository;
        readonly private IBookReadRepository _bookReadRepository;
        public BookController(IBookWriteRepository bookWriteRepository,IBookReadRepository bookReadRepository)
        {
            _bookWriteRepository = bookWriteRepository;
            _bookReadRepository = bookReadRepository;   
        }

        [HttpGet]
        public async Task Get()
        {
            Book book = await _bookReadRepository.GetByIdAsync("D557C164-E016-46BB-A2F0-0C4CA5E2EA0C");
            book.Price = 100;
            await _bookWriteRepository.SaveAsync();


        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
           Book book=await  _bookReadRepository.GetByIdAsync(id);
            return Ok(book);    
        }
    }
}

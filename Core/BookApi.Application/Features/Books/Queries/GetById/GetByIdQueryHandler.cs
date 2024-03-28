using BookWebApi.Application.DTOs;
using BookWebApi.Application.Features.Books.Queries.GetAllBooks;
using BookWebApi.Application.Features.Books.Queries.GetById;
using BookWebApi.Application.Interfaces.AutoMapper;
using BookWebApi.Application.Interfaces.UnitOfWorks;
using BookWebApi.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Queries.GetByIdBook
{

    public class GetByIdQueryHandler : IRequestHandler<GetByIdQueryRequest, GetByIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

       

        public async Task<GetByIdQueryResponse> Handle(GetByIdQueryRequest request, CancellationToken cancellationToken)
        {

            var books = await _unitOfWork.GetReadRepository<Book>()
                .GetByIdAsync(request.Id,include:x=>x.Include(y=>y.Author).Include(y=>y.Category));





            var author = _mapper.Map<AuthorDto, Author>(books.Author);

            var category = _mapper.Map<CategoryDto, Category>(books.Category);



            var response = _mapper.Map<GetByIdQueryResponse, Book>(books);


            return response;

        }
    }
}
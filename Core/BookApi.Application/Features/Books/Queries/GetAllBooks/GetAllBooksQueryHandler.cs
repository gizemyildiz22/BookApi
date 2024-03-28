using BookWebApi.Application.DTOs;
using BookWebApi.Application.Interfaces.AutoMapper;
using BookWebApi.Application.Interfaces.UnitOfWorks;
using BookWebApi.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Queries.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQueryRequest, IList<GetAllBooksQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllBooksQueryHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this._unitOfWork=unitOfWork;
            this._mapper=mapper;
        }



        public async Task<IList<GetAllBooksQueryResponse>> Handle(GetAllBooksQueryRequest request, CancellationToken cancellationToken)
        {
            var books = await _unitOfWork.GetReadRepository<Book>().GetAllAsync(
                include: x => x.Include(b => b.Author)

                .Include(b => b.Category));

            var author = _mapper.Map<AuthorDto, Author>(new Author());

            var category = _mapper.Map<CategoryDto, Category>(new Category());

            var map = _mapper.Map<GetAllBooksQueryResponse, Book>(books);

            return map;
        }
    }
}

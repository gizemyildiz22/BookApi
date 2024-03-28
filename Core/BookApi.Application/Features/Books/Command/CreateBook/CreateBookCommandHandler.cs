using BookWebApi.Application.Base;
using BookWebApi.Application.Features.Books.Rules;
using BookWebApi.Application.Interfaces.AutoMapper;
using BookWebApi.Application.Interfaces.UnitOfWorks;
using BookWebApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Command.CreateBook
{
    public class CreateBookCommandHandler : BaseHandler, IRequestHandler<CreateBookCommandRequest,Unit>
    {
        
        private readonly BookRules bookRules;

        public CreateBookCommandHandler(BookRules bookRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            
            this.bookRules = bookRules;
        }   
        public async Task<Unit> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Book> books = await unitOfWork.GetReadRepository<Book>().GetAllAsync();

            await bookRules.BookNameMustNotBeSame(books, request.Book_Name);
            Book book = new(request.Book_Name,request.Book_Description,request.Book_Url,request.Print_Length,request.AuthorId, request.Price, request.Stock, request.ISBN,request.CategoryId);
            await unitOfWork.GetWriteRepository<Book>().AddAsync(book);

            if(await unitOfWork.SaveAsync()>0)
            {
                foreach (var orderId in request.BookOrders)
                {
                    await unitOfWork.GetWriteRepository<BookOrder>().AddAsync(new()
                    {
                        BookId=book.Id,
                        OrderId = orderId
                    });

                    await unitOfWork.SaveAsync();
                }
            }

            return Unit.Value;
        }
    }
}

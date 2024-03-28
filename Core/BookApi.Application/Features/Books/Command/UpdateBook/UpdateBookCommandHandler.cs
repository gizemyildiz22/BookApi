using BookWebApi.Application.Base;
using BookWebApi.Application.Interfaces.AutoMapper;
using BookWebApi.Application.Interfaces.UnitOfWorks;
using BookWebApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Command.UpdateBook
{
    public class UpdateBookCommandHandler : BaseHandler, IRequestHandler<UpdateBookCommandRequest,Unit>
    {
        
        public UpdateBookCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            
        }
        public async Task<Unit> Handle(UpdateBookCommandRequest request, CancellationToken cancellationToken)
        {
            var book=await unitOfWork.GetReadRepository<Book>().GetAsync(x=>x.Id==request.Id && !x.IsDeleted);
            var map = mapper.Map<Book, UpdateBookCommandRequest>(request);
            var bookOrders=await unitOfWork.GetReadRepository<BookOrder>()
                .GetAllAsync(x=>x.BookId==book.Id);

            await unitOfWork.GetWriteRepository<BookOrder>()
                .DeleteRangeAsync(bookOrders);

            foreach (var orderId in request.OrderIds)
                await unitOfWork.GetWriteRepository<BookOrder>()
                    .AddAsync(new() { OrderId=orderId,BookId=book.Id});

            await unitOfWork.GetWriteRepository<Book>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}

using BookWebApi.Application.Base;
using BookWebApi.Application.Interfaces.AutoMapper;
using BookWebApi.Application.Interfaces.UnitOfWorks;
using BookWebApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Orders.Command.CreateOrder
{
    public class CreateOrderCommandHandler : BaseHandler, IRequestHandler<CreateOrderCommandRequest, Unit>
    {
        public CreateOrderCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {

        }

        public async Task<Unit> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            Order order = new(request.OrderDescription,request.Address,request.CustomerId);

            await unitOfWork.GetWriteRepository<Order>().AddAsync(order);

            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var bookId in request.BooksIds)
                {
                    await unitOfWork.GetWriteRepository<BookOrder>().AddAsync(new()
                    {
                        OrderId = order.Id,
                        BookId = bookId
                    });

                    await unitOfWork.SaveAsync();
                }
            }

            return Unit.Value;
        }
    }
}

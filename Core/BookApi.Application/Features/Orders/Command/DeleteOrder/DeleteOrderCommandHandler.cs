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

namespace BookWebApi.Application.Features.Orders.Command.DeleteOrder
{
    public class DeleteOrderCommandHandler : BaseHandler, IRequestHandler<DeleteOrderCommandRequest, Unit>
    {

        public DeleteOrderCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {

        }
        public async Task<Unit> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var order = await unitOfWork.GetReadRepository<Order>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            order.IsDeleted = true;
            await unitOfWork.GetWriteRepository<Order>().UpdateAsync(order);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }

}

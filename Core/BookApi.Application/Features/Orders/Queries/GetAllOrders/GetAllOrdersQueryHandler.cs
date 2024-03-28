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

namespace BookWebApi.Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQueryRequest, IList<GetAllOrdersQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllOrdersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }
        public async Task<IList<GetAllOrdersQueryResponse>> Handle(GetAllOrdersQueryRequest request, CancellationToken cancellationToken)
        {
            var orders = await _unitOfWork.GetReadRepository<Order>().GetAllAsync(
                include: x => x.Include(b => b.Customer));
               

            var customer = _mapper.Map<CustomerDto, Customer>(new Customer());
         

            var map = _mapper.Map<GetAllOrdersQueryResponse, Order>(orders);

            return map;
        }
    }
}

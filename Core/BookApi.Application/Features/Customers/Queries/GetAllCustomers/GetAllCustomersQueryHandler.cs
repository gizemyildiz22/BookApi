using BookWebApi.Application.Base;
using BookWebApi.Application.Features.Customers.Queries.GetAllCustomers;
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

namespace BookWebApi.Application.Features.Customers.Queries.GetAllCustomers
{
    public class GetAllCustomersQueryHandler : BaseHandler, IRequestHandler<GetAllCustomersQueryRequest, IList<GetAllCustomersQueryResponse>>
    {
        public GetAllCustomersQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<IList<GetAllCustomersQueryResponse>> Handle(GetAllCustomersQueryRequest request, CancellationToken cancellationToken)
        {
            var customers=await unitOfWork.GetReadRepository<Customer>().GetAllAsync();
            return mapper.Map<GetAllCustomersQueryResponse, Customer>(customers);
        }
    }
}

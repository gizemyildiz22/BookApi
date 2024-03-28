using BookWebApi.Application.Base;
using BookWebApi.Application.Features.Customers.Command.CreateCustomer;
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

namespace BookWebApi.Application.Features.Customers.Command.CreateCustomer
{
    public class CreateCustomerCommandHandler : BaseHandler, IRequestHandler<CreateCustomerCommandRequest, Unit>
    {
        public CreateCustomerCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            
        }

        public async Task<Unit> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            Customer customer = new(request.Name, request.Surname, request.Email, request.Phone);

            await unitOfWork.GetWriteRepository<Customer>().AddAsync(customer);
            await unitOfWork.SaveAsync();

            return Unit.Value;


        }
    }
}

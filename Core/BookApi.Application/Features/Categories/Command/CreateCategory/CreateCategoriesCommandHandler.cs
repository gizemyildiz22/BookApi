using Bogus;
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

namespace BookWebApi.Application.Features.Customers.Command.CreateCategory
{
    public class CreateCategoriesCommandHandler : BaseHandler, IRequestHandler<CreateCategoriesCommandRequest, Unit>
    {
        public CreateCategoriesCommandHandler(IMapper mapper,IUnitOfWork unitOfWork,IHttpContextAccessor httpContextAccessor):base(mapper,unitOfWork,httpContextAccessor)
        {
            
        }
        public async Task<Unit> Handle(CreateCategoriesCommandRequest request, CancellationToken cancellationToken)
        {
            Category categories  = new(request.CategoryName);

            await unitOfWork.GetWriteRepository<Category>().AddAsync(categories);

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}

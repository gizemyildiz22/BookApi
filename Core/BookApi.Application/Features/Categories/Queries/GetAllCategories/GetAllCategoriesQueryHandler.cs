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

namespace BookWebApi.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler :BaseHandler, IRequestHandler<GetAllCategoriesQueryRequest, IList<GetAllCategoriesQueryResponse>>
    {
        public GetAllCategoriesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<IList<GetAllCategoriesQueryResponse>> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var categories = await unitOfWork.GetReadRepository<Category>().GetAllAsync();
            return mapper.Map<GetAllCategoriesQueryResponse, Category>(categories);
        }
    }
}

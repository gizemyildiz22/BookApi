using BookWebApi.Application.Base;
using BookWebApi.Application.Features.Authors.Queries.GetAllAuthors;
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

namespace BookWebApi.Application.Features.Authors.Queries.GetAllAuthors
{
    public class GetAllAuthorsQueryHandler : BaseHandler, IRequestHandler<GetAllAuthorsQueryRequest, IList<GetAllAuthorsQueryResponse>>
    {
        public GetAllAuthorsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<IList<GetAllAuthorsQueryResponse>> Handle(GetAllAuthorsQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await unitOfWork.GetReadRepository<Author>().GetAllAsync();
            return mapper.Map<GetAllAuthorsQueryResponse, Author>(authors);
        }
    }
}

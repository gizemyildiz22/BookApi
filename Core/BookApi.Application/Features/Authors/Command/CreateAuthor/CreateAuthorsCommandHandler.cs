using BookWebApi.Application.Base;
using BookWebApi.Application.Features.Authors.Command.CreateAuthor;
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

namespace BookWebApi.Application.Features.Command.CreateAuthor
{
    public class CreateAuthorsCommandHandler : BaseHandler, IRequestHandler<CreateAuthorsCommandRequest, Unit>
    {
        public CreateAuthorsCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(CreateAuthorsCommandRequest request, CancellationToken cancellationToken)
        {
            Author authors = new(request.AuthorName,request.AuthorSurname);

            await unitOfWork.GetWriteRepository<Author>().AddAsync(authors);

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
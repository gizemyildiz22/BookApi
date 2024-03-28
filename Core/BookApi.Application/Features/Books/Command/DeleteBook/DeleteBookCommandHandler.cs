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

namespace BookWebApi.Application.Features.Books.Command.DeleteBook
{
    public class DeleteBookCommandHandler : BaseHandler, IRequestHandler<DeleteBookCommandRequest,Unit>
    {
        
        public DeleteBookCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            
        }
        public async Task<Unit> Handle(DeleteBookCommandRequest request, CancellationToken cancellationToken)
        {
            var book = await unitOfWork.GetReadRepository<Book>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            book.IsDeleted = true;
            await unitOfWork.GetWriteRepository<Book>().UpdateAsync(book);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}

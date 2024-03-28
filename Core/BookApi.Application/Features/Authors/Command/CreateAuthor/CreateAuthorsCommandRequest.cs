using BookWebApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Authors.Command.CreateAuthor
{
    public class CreateAuthorsCommandRequest : IRequest<Unit>
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }

        
    }
}

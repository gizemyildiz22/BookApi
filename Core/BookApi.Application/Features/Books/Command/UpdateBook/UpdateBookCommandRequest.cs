using BookWebApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Command.UpdateBook
{
    public class UpdateBookCommandRequest:IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Page { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        public int PublisherId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public IList<int> OrderIds { get; set; }
    }
}

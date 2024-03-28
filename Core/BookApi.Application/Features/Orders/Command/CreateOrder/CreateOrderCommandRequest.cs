using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Orders.Command.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<Unit>
    {
        public string OrderDescription { get; set; }
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public IList<int> BooksIds { get; set; }
    }
}

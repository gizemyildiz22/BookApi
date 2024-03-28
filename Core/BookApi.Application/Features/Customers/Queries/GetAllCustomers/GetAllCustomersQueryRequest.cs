using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Customers.Queries.GetAllCustomers
{
    public class GetAllCustomersQueryRequest : IRequest<IList<GetAllCustomersQueryResponse>>
    {
    }
}

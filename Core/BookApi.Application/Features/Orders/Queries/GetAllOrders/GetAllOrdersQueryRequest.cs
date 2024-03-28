using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrdersQueryRequest : IRequest<IList<GetAllOrdersQueryResponse>>
    {
    }
}

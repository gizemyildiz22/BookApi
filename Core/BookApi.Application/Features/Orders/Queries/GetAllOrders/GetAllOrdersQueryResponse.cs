using BookWebApi.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrdersQueryResponse
    {
        public string OrderDescription { get; set; }
        public string Address { get; set; }
        public CustomerDto  Customer { get; set; }
        
    }
}

using BookWebApi.Domain;
using BookWebApi.Domain.Common;
using BookWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Domain.Entities
{
    public class Order:BaseEntity
    {
        public Order() { }
        public Order(string orderDescription, string address, int customerId)
        {
            OrderDescription = orderDescription;
            Address = address;
            CustomerId = customerId;

        }

        public string OrderDescription { get; set; }
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<BookOrder> BookOrders { get; set; }

    }
}

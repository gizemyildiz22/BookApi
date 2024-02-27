using BookApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApi.Domain.Entities
{
    public class Order:BaseEntity
    {
        public string OrderDescription { get; set; }
        public string Address { get; set; }
        public ICollection<Book>Books { get; set; }
        public Customer Customer { get; set; }  
    }
}

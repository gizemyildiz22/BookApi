using BookWebApi.Domain.Common;
using BookWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Domain.Entities
{
    public class BookOrder:BaseEntity
    {
        
        public int BookId { get; set; }
        public int OrderId { get; set; }
        public Book Book { get; set; }
        public Order Order { get; set; }

        public static implicit operator int(BookOrder v)
        {
            throw new NotImplementedException();
        }
    }
}

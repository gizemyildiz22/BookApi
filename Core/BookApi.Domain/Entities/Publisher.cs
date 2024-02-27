using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookApi.Domain.Entities.Common;

namespace BookApi.Domain.Entities
{
    public class Publisher : BaseEntity
    {
        public string PublisherName { get; set; }
        public string PublisherDescription { get; set; }

        public bool IsActive { get; set; } = false;
        public ICollection<Book> Books { get; set; }
    }
}

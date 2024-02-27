using BookApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApi.Domain.Entities
{
    public class Author:BaseEntity
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public bool IsActive { get; set; }=false;
        public string AuthorDescription { get; set; }

    }
}

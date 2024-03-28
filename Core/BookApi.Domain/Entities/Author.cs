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
    public class Author:BaseEntity
    {
        public Author() { }
        public Author(string authorName, string authorSurname)
        {
            AuthorName = authorName;
            AuthorSurname = authorSurname;
        }

        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        

    }
}

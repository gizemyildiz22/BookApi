using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Authors.Queries.GetAllAuthors
{
    public class GetAllAuthorsQueryResponse
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public bool IsDeleted { get; set; }

    }
}

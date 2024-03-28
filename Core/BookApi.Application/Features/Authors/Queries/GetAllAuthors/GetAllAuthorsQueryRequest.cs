using BookWebApi.Application.Features.Categories.Queries.GetAllCategories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Authors.Queries.GetAllAuthors
{
    public class GetAllAuthorsQueryRequest : IRequest<IList<GetAllAuthorsQueryResponse>>
    {
    }
}

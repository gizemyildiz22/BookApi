﻿
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryRequest : IRequest<IList<GetAllCategoriesQueryResponse>>
    {
        
    }
}

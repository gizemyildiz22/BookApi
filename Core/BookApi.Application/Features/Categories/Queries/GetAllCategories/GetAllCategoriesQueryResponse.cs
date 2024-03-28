using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryResponse
    {
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; } 
    }
}

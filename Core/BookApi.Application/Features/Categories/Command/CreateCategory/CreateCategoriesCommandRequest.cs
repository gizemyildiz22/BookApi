using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Customers.Command.CreateCategory
{
    public class CreateCategoriesCommandRequest:IRequest<Unit>
    {
        public string CategoryName { get; set; }

    }
}

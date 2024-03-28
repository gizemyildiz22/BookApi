using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWebApi.Domain.Common;
using BookWebApi.Domain.Entities.Common;

namespace BookWebApi.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category() 
        { 

        }
        public Category(string name) 
        {

            CategoryName = name;

        }

        public string CategoryName { get; set; }
        
       
    }
}

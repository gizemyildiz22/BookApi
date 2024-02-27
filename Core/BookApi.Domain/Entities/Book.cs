using BookApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookApi.Domain.Entities
{
    public class Book:BaseEntity
    {
        
        public string Name { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }  
        public int PageCount {  get; set; } 
        public int Stock {  get; set; } 
        public string Description { get; set; }
        public bool IsActive { get; set; } = false;
        public long ISBN { get; set; }
        public Publisher Publisher { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}

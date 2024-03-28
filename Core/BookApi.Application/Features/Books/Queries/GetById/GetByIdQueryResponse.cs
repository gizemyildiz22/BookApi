using BookWebApi.Application.DTOs;
using BookWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Queries.GetById
{
    public class GetByIdQueryResponse
    {
        public int Id { get; set; }
        public string book_Name { get; set; }
        public string book_Description { get; set; }
        public string book_Url { get; set; }
        public int print_Length { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
        public AuthorDto Author { get; set; }

        public CategoryDto Category { get; set; }
        public ICollection<BookOrder> BookOrders { get; set; }
    }
}

using BookWebApi.Application.DTOs;
using BookWebApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Queries.GetAllBooks
{
    public class GetAllBooksQueryResponse
    {
        public int id { get; set; }
        public string book_Name { get; set; }
        public string book_Description { get; set; }
        public string book_Url { get; set; }
        public int print_Length { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int ISBN { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
        public ICollection<BookOrder> BookOrders { get; set; }


    }
}

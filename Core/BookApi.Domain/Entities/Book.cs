using BookWebApi.Domain;
using BookWebApi.Domain.Common;
using BookWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Domain.Entities
{
    public class Book:BaseEntity
    {
        public Book() 
        {

        }
        public Book(string book_name, string book_description, string book_url,int print_length, int authorId, decimal price, int stock, int iSBN,int categoryId)
        {
            book_Name = book_name;
            book_Description = book_description;
            book_Url = book_url;
            print_Length = print_length;
            AuthorId = authorId;
            Price = price;
            Stock = stock;
            ISBN = iSBN;
            CategoryId = categoryId;
        }

        public string book_Name { get; set; }
        public string book_Description { get; set; }
        public string book_Url { get; set; }
        public int print_Length { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }  
        public int Stock {  get; set; } 
        public int ISBN { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
        public ICollection<BookOrder> BookOrders { get; set; }

    }
}

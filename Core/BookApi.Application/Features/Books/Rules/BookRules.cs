using BookWebApi.Application.Base;
using BookWebApi.Application.Features.Books.Exceptions;
using BookWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Rules
{
    public class BookRules:BaseRules
    {
        public Task BookNameMustNotBeSame(IList<Book>books,string requestName)
        {
            if (books.Any(x=>x.book_Name==requestName)) throw new BookNameMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}

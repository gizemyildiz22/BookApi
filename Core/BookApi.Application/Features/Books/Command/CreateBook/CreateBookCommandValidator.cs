using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Command.CreateBook
{
    public class CreateBookCommandValidator:AbstractValidator<CreateBookCommandRequest>
    {
        public CreateBookCommandValidator() 
        {
            RuleFor(x => x.Book_Name).NotEmpty().WithName("Kitap Adı");
            RuleFor(x => x.Book_Description).NotEmpty().WithName("Açıklama");
            RuleFor(x => x.Price).GreaterThan(0).WithName("Fiyat");
            RuleFor(x => x.Print_Length).GreaterThan(0).WithName("Sayfa Sayısı");
            RuleFor(x => x.Stock).GreaterThan(0).WithName("Stok");
            RuleFor(x => x.ISBN).GreaterThan(0).WithName("ISBN");
            RuleFor(x => x.AuthorId).GreaterThan(0).WithName("Yazar");
            RuleFor(x => x.CategoryId).GreaterThan(0).WithName("Kategori");
        }
    }
}

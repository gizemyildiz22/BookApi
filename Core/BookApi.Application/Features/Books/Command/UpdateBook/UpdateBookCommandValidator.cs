using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Command.UpdateBook
{
    public class UpdateBookCommandValidator:AbstractValidator<UpdateBookCommandRequest>
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Name).NotEmpty().WithName("Kitap Adı");
            RuleFor(x => x.Description).NotEmpty().WithName("Açıklama");
            RuleFor(x => x.Price).GreaterThan(0).WithName("Fiyat");
            RuleFor(x => x.Page).GreaterThan(0).WithName("Syafa Sayısı");
            RuleFor(x => x.Stock).GreaterThan(0).WithName("Stok");
            RuleFor(x => x.ISBN).GreaterThan(0).WithName("ISBN");
            RuleFor(x => x.PublisherId).GreaterThan(0).WithName("Yayınevi");
            RuleFor(x => x.AuthorId).GreaterThan(0).WithName("Yazar");
            RuleFor(x => x.CategoryId).GreaterThan(0).WithName("Kategori");
            RuleFor(x => x.OrderIds).NotEmpty().Must(orders => orders.Any()).WithName("Siparişler");
        }
    }
}

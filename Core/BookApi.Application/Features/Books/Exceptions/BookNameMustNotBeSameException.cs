using BookWebApi.Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Exceptions
{
    public class BookNameMustNotBeSameException:BaseException
    {
        public BookNameMustNotBeSameException():base("Kitap adı zaten var!") { }
    }
}

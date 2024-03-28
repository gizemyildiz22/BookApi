using BookWebApi.Application.DTOs;
using BookWebApi.Application.Features.Books.Queries.GetAllBooks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Features.Books.Queries.GetById
{
    public class GetByIdQueryRequest : IRequest<GetByIdQueryResponse>
    {
        public int Id { get; set; }
       

        public GetByIdQueryRequest(int id)
        {
            Id = id;
            
        }
    }
}

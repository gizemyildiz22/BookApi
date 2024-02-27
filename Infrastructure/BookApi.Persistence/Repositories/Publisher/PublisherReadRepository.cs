using BookApi.Application.Repositories;
using BookApi.Domain.Entities;
using BookApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApi.Persistence.Repositories
{
    public class PublisherReadRepository : ReadRepository<Publisher>, IPublisherReadRepository
    {
        public PublisherReadRepository(BookApiDbContext context) : base(context)
        {
        }
    }
}

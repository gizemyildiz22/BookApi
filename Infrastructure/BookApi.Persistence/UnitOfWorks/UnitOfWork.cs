using BookWebApi.Application.Interfaces.Repositories;
using BookWebApi.Application.Interfaces.UnitOfWorks;
using BookWebApi.Persistence.Context;
using BookWebApi.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookApiDbContext _dbContext;
        public UnitOfWork(BookApiDbContext dbContext) 
        {
            this._dbContext = dbContext;
        }

        public async ValueTask DisposeAsync()=> await _dbContext.DisposeAsync();
        

        public int Save()=>_dbContext.SaveChanges();

        public async Task<int> SaveAsync()=>await _dbContext.SaveChangesAsync();

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(_dbContext);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()=>new WriteRepository<T>(_dbContext);
    }
}

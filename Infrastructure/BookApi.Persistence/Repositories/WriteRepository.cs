﻿using BookWebApi.Application.Interfaces.Repositories;
using BookWebApi.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Persistence.Repositories
{
    public class WriteRepository<T>:IWriteRepository<T> where T : class,IBaseEntity,new()
    {
        private readonly DbContext dbContext;

        public WriteRepository(DbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        
        private DbSet<T> Table { get=>dbContext.Set<T>(); }

        public async Task  AddAsync(T entity)
        {
            await Table.AddAsync(entity); 
           
        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(()=>Table.Update(entity));
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(()=>Table.Remove(entity));
    
        }

        public async Task DeleteRangeAsync(IList<T> entity)
        {
            await Task.Run(() => Table.RemoveRange(entity));

        }



    }
}

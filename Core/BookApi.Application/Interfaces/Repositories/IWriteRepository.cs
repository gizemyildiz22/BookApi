﻿using BookWebApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class,IBaseEntity,new()
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        Task DeleteRangeAsync(IList<T> entity);


    }
}

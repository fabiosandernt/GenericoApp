using GenericoApp.Domain.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericoApp.Infrastructure.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> Query;
        protected DbContext Context;

        public Repository(DbContext context)
        {
            this.Context = context;
            this.Query = context.Set<T>();
        }

        public ValueTask<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAllByCriterio(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.Query.ToListAsync();
        }

        public ValueTask<T> GetbyExpressionAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task Save(T entity)
        {
           await this.Query.AddAsync(entity);
           await this.Context.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }    
}

using GenericoApp.Domain.Base;
using GenericoApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GenericoApp.Infrastructure.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }

        public Repository(ApplicationDbContext context)
        {
            this.Query = Context.Set<T>();
            this.Context = context;            
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await Query.AnyAsync(expression);
        }

        public async Task DeleteAsync(T entity)
        {
            Query.Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllByCriterio(Expression<Func<T, bool>> expression)
        {
            return await Query.Where(expression).ToListAsync();
        }

        public async Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression)
        {
            return await Query.Where(expression).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await Query.ToListAsync();
        }
           

        public async Task<T> GetByIdAsync(object id)
        {
           return await Query.FindAsync(id);
        }

        public async Task SaveAsync(T entity)
        {
            await Query.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            Query.Update(entity);
            await Context.SaveChangesAsync();
        }
    }
}

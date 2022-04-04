using EstacaoRecarga.Domain.Interfaces.Repositories;
using EstacaoRecarga.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity, new()
    {

        protected readonly EstacaoContext estacaoContext;

        public RepositoryBase(EstacaoContext context)
        {
            estacaoContext = context ?? throw new ArgumentException(nameof(context));
        }

        public  async Task DeleteAsync(T obj)
        {
            estacaoContext.Set<T>().Remove(obj);
            await estacaoContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await estacaoContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(Guid guid)
        {
            return await estacaoContext.Set<T>().Where(x => x.Id == guid).FirstOrDefaultAsync();
        }

        public async Task SaveAsync(T obj)
        {
            await estacaoContext.Set<T>().AddAsync(obj);
            await estacaoContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T obj)
        {
            estacaoContext.Entry(obj).State = EntityState.Modified;
            await estacaoContext.SaveChangesAsync();
        }
    }
}

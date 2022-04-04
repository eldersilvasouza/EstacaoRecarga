using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstacaoRecarga.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetById(Guid guid);
        Task SaveAsync(T obj);
        Task UpdateAsync(T obj);
        Task DeleteAsync(T obj);
    }
}

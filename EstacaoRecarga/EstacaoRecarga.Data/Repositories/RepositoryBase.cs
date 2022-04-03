using EstacaoRecarga.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
      

        public Task<bool> DeleteAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetById(Guid guid)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}

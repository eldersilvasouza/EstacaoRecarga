using EstacaoRecarga.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {



        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}

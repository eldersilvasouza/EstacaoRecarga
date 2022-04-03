using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
       Task<List<T>> GetAllAsync();
        Task<T> GetById(Guid guid);
        Task SaveAsync(T obj);



    }
}

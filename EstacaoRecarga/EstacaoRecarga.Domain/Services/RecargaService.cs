using EstacaoRecarga.Domain.Interfaces.Repositories;
using EstacaoRecarga.Domain.Interfaces.Services;
using EstacaoRecarga.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Domain.Services
{
    public class RecargaService : IRecargaService
    {

        private readonly IRepositoryBase<Estacao> _repository;

        public RecargaService(IRepositoryBase<Estacao> repository)
        {

            _repository = repository;

        }

        public async Task<Estacao> AtualizarRecarga(Estacao estacaoRecarga)
        {

            await _repository.UpdateAsync(estacaoRecarga);
            return estacaoRecarga;


        }

        public async Task<bool> DeletarEstacao(Guid id)
        {
            var estacaoRecarga = _repository.GetById(id);
            if (estacaoRecarga != null)
            {
                await _repository.DeleteAsync(estacaoRecarga.Result);
                return true;
            }
            return false;
        }

        public async Task<Estacao> IncluirRecarga(Estacao estacaoRecarga)
        {

            await _repository.SaveAsync(estacaoRecarga);
            return estacaoRecarga;
        }

        public async Task<List<Estacao>> ListarEstacoes()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Estacao> PesquisarEstacao(Guid id)
        {
            return await _repository.GetById(id);
        }
    }
}

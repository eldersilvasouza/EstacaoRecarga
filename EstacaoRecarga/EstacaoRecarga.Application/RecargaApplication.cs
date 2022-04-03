using EstacaoRecarga.Domain.Interfaces.Services;
using EstacaoRecarga.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Application
{
    public class RecargaApplication : IRecargaApplication
    {
        private readonly IRecargaService _recargaService;

        public RecargaApplication(IRecargaService recargaService)
        {
            _recargaService = recargaService;
        }

        public async  Task<Estacao> AtualizarRecarga(Estacao estacaoRecarga)
        {
            await _recargaService.AtualizarRecarga(estacaoRecarga);
            return estacaoRecarga;
        }

        public async  Task<Estacao> IncluirRecarga(Estacao estacaoRecarga)
        {
            await _recargaService.IncluirRecarga(estacaoRecarga);
            return estacaoRecarga;
        }

        public async Task<Estacao> PesquisarEstacao(Guid id)
        {
            return await _recargaService.PesquisarEstacao(id);
        }

        public async Task<List<Estacao>> PesquisarEstacoes()
        {
            return await _recargaService.ListarEstacoes();
        }
    }
}

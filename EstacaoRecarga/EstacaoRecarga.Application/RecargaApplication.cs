using EstacaoRecarga.Domain.Interfaces.Services;
using EstacaoRecarga.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Application
{
    public class RecargaApplication : IRecargaService
    {




        public async Task<Estacao> AtualizarRecarga(Estacao estacaoRecarga)
        {
            throw new NotImplementedException();
        }

        public async  Task<bool> DeletarEstacao(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Estacao> IncluirRecarga(Estacao estacaoRecarga)
        {
            throw new NotImplementedException();
        }

        public async  Task<List<Estacao>> ListarEstacoes()
        {
            throw new NotImplementedException();
        }

        public async  Task<Estacao> PesquisarEstacao(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

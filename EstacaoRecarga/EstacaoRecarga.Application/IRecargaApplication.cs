using EstacaoRecarga.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Application
{
    public interface IRecargaApplication
    {

        Task<Estacao> IncluirRecarga(Estacao estacaoRecarga);
        Task<Estacao> AtualizarRecarga(Estacao estacaoRecarga);
        Task<Estacao> PesquisarEstacao(Guid id);
        Task<List<Estacao>> PesquisarEstacoes();



    }
}

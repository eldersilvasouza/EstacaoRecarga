using EstacaoRecarga.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Application
{
    public interface IRecarcaApplication
    {

        Task<Estacao> IncluirRecarga(Estacao estacaoRecarga);
        Task<Estacao> AtualizarRecarga(Estacao estacaoRecarga);
        Task<Estacao> PesquisarEstacao(Guid id);
        


    }
}

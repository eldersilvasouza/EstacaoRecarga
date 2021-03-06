using EstacaoRecarga.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstacaoRecarga.Domain.Interfaces.Services
{
   public  interface IRecargaService
    {
        Task<Estacao> IncluirRecarga(Estacao estacaoRecarga);
        Task<Estacao> AtualizarRecarga(Estacao estacaoRecarga);
        Task<Estacao> PesquisarEstacao(Guid id);
        Task<bool> DeletarEstacao(Guid id);
        Task<List<Estacao>> ListarEstacoes();


    }
}

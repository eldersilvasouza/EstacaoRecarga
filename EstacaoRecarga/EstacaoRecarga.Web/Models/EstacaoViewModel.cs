using EstacaoRecarga.Web.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacaoRecarga.Web.Models
{
    public class EstacaoViewModel
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get; set; }
        public TipoEstacaoViewModel tipoEstacao { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
    }
}

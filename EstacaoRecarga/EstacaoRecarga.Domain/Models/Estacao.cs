using EstacaoRecarga.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoRecarga.Domain.Models
{
    public class Estacao : IEntity
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get; set; }
        public TipoEstacao tipoEstacao { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
    }
}

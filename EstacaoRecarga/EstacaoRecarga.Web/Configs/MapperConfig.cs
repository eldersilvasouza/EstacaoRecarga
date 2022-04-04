using AutoMapper;
using EstacaoRecarga.Domain.Models;
using EstacaoRecarga.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacaoRecarga.Web.Configs
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {

            CreateMap<Estacao, EstacaoViewModel>().ReverseMap();

        }


    }
}

using AutoMapper;
using EstacaoRecarga.Application;
using EstacaoRecarga.Domain.Models;
using EstacaoRecarga.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacaoRecarga.Web.Controllers
{
    public class EstacaoRecargaController : Controller
    {
        private readonly IRecargaApplication _recargaApplication;
        private readonly IMapper _mapper;

        public EstacaoRecargaController(IRecargaApplication recargaApplication, IMapper mapper)
        {
            _recargaApplication = recargaApplication;
            _mapper = mapper;
        }

        public async Task<ActionResult<EstacaoViewModel>> PesquisarEstacao(Guid id)
        {

            var estacaoViewModel = _mapper.Map<EstacaoViewModel>(await _recargaApplication.PesquisarEstacao(id));
            return estacaoViewModel;

        }

        public async Task<IActionResult> SalvarEstacao(EstacaoViewModel estacaoViewModel)
        {

            await _recargaApplication.IncluirRecarga(_mapper.Map<Estacao>(estacaoViewModel));

             return View(estacaoViewModel);


        }

        public async Task<IActionResult> AtualizarEstacao (EstacaoViewModel estacaoViewModel)
        {
            await _recargaApplication.AtualizarRecarga(_mapper.Map<Estacao>(estacaoViewModel));

            return View(estacaoViewModel);


        }


        public async Task<IActionResult> Index()
        {
            var estacaoRecarga =_mapper.Map<IEnumerable<EstacaoViewModel>>(await  _recargaApplication.PesquisarEstacoes());

            return View(estacaoRecarga);
        }


       
    }
}


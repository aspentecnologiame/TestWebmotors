using AutoMapper;
using MarcosCosta.Api.Models.DTO;
using MarcosCosta.Api.Models.Response;
using MarcosCosta.Domain.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MarcosCosta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        private readonly IMapper _mapper;

        public VeiculoController(IVeiculoService veiculoService, IMapper mapper)
        {
            this._veiculoService = veiculoService;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("Marcas")]
        public IActionResult Marcas()
        {
            var marcas = _veiculoService.GetMarcas();
            var marcasDTO = _mapper.Map<IEnumerable<MarcaDTO>>(marcas);
            var response = new MarcaListResponse(marcasDTO);

            return Ok(response);
        }

        [HttpGet]
        [Route("Modelos")]
        public IActionResult Models([FromQuery] int makeId)
        {
            var modelos = _veiculoService.GetModels(makeId);
            var modelosDTO = _mapper.Map<IEnumerable<ModeloDTO>>(modelos);
            var response = new ModeloListResponse(modelosDTO);

            return Ok(response);
        }

        [HttpGet]
        [Route("Versoes")]
        public IActionResult Versions([FromQuery] int modelId)
        {
            var versoes = _veiculoService.GetVersions(modelId);
            var versoesDTO = _mapper.Map<IEnumerable<VersaoDTO>>(versoes);
            var response = new VersaoListResponse(versoesDTO);

            return Ok(response);
        }
    }
}

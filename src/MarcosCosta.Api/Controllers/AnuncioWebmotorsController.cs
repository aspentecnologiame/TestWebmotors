using AutoMapper;
using MarcosCosta.Api.Models.DTO;
using MarcosCosta.Api.Models.DTO.Request;
using MarcosCosta.Api.Models.DTO.Response;
using MarcosCosta.Api.Models.Response;
using MarcosCosta.Domain;
using MarcosCosta.Domain.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioWebmotorsController : ControllerBase
    {
        private readonly IAnuncioWebmotorsService _anuncioWebmotorsService;
        private readonly IMapper _mapper;
        public AnuncioWebmotorsController(IAnuncioWebmotorsService anuncioWebmotorsService, IMapper mapper)
        {
            this._anuncioWebmotorsService = anuncioWebmotorsService;
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var anuncioWebmotorsRepositoryList = _anuncioWebmotorsService.GetAll();
            var anuncioWebmotorsListDTO = _mapper.Map<IEnumerable<AnuncioWebMotorsDTO>>(anuncioWebmotorsRepositoryList);
            var response = new AnuncioWebmotorsListResponse(anuncioWebmotorsListDTO);

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Insert(AnuncioWebmotorsRequest anuncioWebmotorsRequest)
        {
            try
            {
                var anuncioWebmotorsEntity = _mapper.Map<AnuncioWebmotorsEntity>(anuncioWebmotorsRequest.Data);
                var save = _anuncioWebmotorsService.Insert(anuncioWebmotorsEntity);
                var response = new StringResponse("Veículo cadastrado com Sucesso!!");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            
        }
    }
}

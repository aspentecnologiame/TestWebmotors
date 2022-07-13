using AutoMapper;
using MarcosCosta.Api.Models.DTO;
using MarcosCosta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Request
            CreateMap<AnuncioWebMotorsDTO, AnuncioWebmotorsEntity>();

            //Response
            CreateMap<AnuncioWebmotorsEntity, AnuncioWebMotorsDTO>();
            CreateMap<MarcaEntity, MarcaDTO>();
            CreateMap<ModeloEntity, ModeloDTO>();
            CreateMap<VersaoEntity, VersaoDTO>();
 
        }
    }
}

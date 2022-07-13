using MarcosCosta.Domain;
using MarcosCosta.Domain.Contracts.Repositories;
using MarcosCosta.Domain.Contracts.Services;
using System;
using System.Collections.Generic;

namespace MarcosCosta.Service
{
    public class AnuncioWebmotorsService : IAnuncioWebmotorsService
    {
        private readonly IAnuncioWebmotorsRepository _anuncioWebmotorsRepository;

        public AnuncioWebmotorsService(IAnuncioWebmotorsRepository anuncioWebmotorsRepository)
        {
            this._anuncioWebmotorsRepository = anuncioWebmotorsRepository;
        }
        public IEnumerable<AnuncioWebmotorsEntity> GetAll()
        {
            return _anuncioWebmotorsRepository.GetAll();
        }

        public bool Insert(AnuncioWebmotorsEntity anuncioWebmotorsEntity)
        {
            return _anuncioWebmotorsRepository.Insert(anuncioWebmotorsEntity);
        }
    }
}

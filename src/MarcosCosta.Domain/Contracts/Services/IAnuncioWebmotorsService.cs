using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosCosta.Domain.Contracts.Services
{
    public interface IAnuncioWebmotorsService
    {
        IEnumerable<AnuncioWebmotorsEntity> GetAll();
        bool Insert(AnuncioWebmotorsEntity anuncioWebmotorsEntity);
    }
}

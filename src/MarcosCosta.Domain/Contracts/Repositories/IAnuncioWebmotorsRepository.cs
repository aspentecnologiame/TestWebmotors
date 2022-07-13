using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosCosta.Domain.Contracts.Repositories
{
    public interface IAnuncioWebmotorsRepository
    {
        IEnumerable<AnuncioWebmotorsEntity> GetAll();
        bool Insert(AnuncioWebmotorsEntity anuncioWebmotorsEntity);
    }
}

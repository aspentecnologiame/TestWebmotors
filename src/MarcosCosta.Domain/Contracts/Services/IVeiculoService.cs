using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosCosta.Domain.Contracts.Services
{
    public interface IVeiculoService
    {
        IEnumerable<MarcaEntity> GetMarcas();
        IEnumerable<ModeloEntity> GetModels(int makeId);
        IEnumerable<VersaoEntity> GetVersions(int modelId);
    }
}

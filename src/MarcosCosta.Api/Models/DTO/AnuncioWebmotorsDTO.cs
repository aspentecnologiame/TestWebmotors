using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Models.DTO
{
    public class AnuncioWebMotorsDTO
    {
        public int ID { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Versao { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string? Observacao { get; set; }
    }
}

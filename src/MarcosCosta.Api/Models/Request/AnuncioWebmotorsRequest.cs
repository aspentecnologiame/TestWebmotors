using MarcosCosta.Api.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Models.DTO.Request
{
    public class AnuncioWebmotorsRequest : BaseRequest<AnuncioWebMotorsDTO>
    {
        public AnuncioWebmotorsRequest(AnuncioWebMotorsDTO data) : base(data)
        {
        }
    }
}

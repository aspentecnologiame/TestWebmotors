using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Models.DTO.Response
{
    public class AnuncioWebMotorsResponse : BaseResponse<AnuncioWebMotorsDTO>
    {
        public AnuncioWebMotorsResponse(AnuncioWebMotorsDTO data) : base(data)
        {
        }
    }
}

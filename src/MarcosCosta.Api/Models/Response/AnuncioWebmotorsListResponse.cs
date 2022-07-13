using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Models.DTO.Response
{
    public class AnuncioWebmotorsListResponse : BaseResponse<IEnumerable<AnuncioWebMotorsDTO>>
    {
        public AnuncioWebmotorsListResponse(IEnumerable<AnuncioWebMotorsDTO> data) : base(data)
        {
        }
    }
}

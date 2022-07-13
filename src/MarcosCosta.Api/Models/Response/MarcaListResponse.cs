using MarcosCosta.Api.Models.DTO;
using MarcosCosta.Api.Models.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Models.Response
{
    public class MarcaListResponse : BaseResponse<IEnumerable<MarcaDTO>>
    {
        public MarcaListResponse(IEnumerable<MarcaDTO> data) : base(data)
        {
        }
    }
}

using MarcosCosta.Api.Models.DTO;
using MarcosCosta.Api.Models.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Models.Response
{
    public class ModeloListResponse : BaseResponse<IEnumerable<ModeloDTO>>
    {
        public ModeloListResponse(IEnumerable<ModeloDTO> data) : base(data)
        {
        }
    }
}

using MarcosCosta.Api.Models.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Models.Response
{
    public class StringResponse : BaseResponse<string>
    {
        public StringResponse(string data) : base(data)
        {
        }
    }
}

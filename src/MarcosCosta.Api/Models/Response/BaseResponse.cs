using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Models.DTO.Response
{
    public abstract class BaseResponse<T> where T : class
    {
        public List<string> Message { get; set; }
        public T Data { get; set; }

        public BaseResponse(T data)
        {
            this.Message = new List<string>();
            this.Data = data;
        }
    }
}

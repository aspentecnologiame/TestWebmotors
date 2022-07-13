using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcosCosta.Api.Models.Request
{
    public class BaseRequest<T> where T : class
    {
        public List<string> Message { get; set; }
        public T Data { get; set; }

        public BaseRequest(T data)
        {
            this.Message = new List<string>();
            this.Data = data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MarcosCosta.Domain.Contracts.ExternalServices
{
    public interface IOnlineChallenge
    {
        Task<string> Makes();
        Task<string> Models(int makeId);
        Task<string> Versions(int modelId);
    }
}

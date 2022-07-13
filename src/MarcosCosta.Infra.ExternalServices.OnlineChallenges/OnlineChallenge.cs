using MarcosCosta.Domain.Contracts.ExternalServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace MarcosCosta.Infra.ExternalServices.OnlineChallenges
{
    public class OnlineChallenge : IOnlineChallenge
    {
        private static readonly HttpClient _client = new HttpClient();
        private static readonly string baseUrl = "https://desafioonline.webmotors.com.br/api/OnlineChallenge";

        public async Task<string> Makes()
        {
            return await GetAsync($"{baseUrl}/Make");
        }

        public async Task<string> Models(int makeId)
        {
            return await GetAsync($"{baseUrl}/Model?MakeId={makeId}");
        }

        public async Task<string> Versions(int modelId)
        {
            return await GetAsync($"{baseUrl}/Version?ModelId={modelId}");
        }

        private async Task<string> GetAsync(string url)
        {
            var response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();

            }

            return null;
        }
    }
}

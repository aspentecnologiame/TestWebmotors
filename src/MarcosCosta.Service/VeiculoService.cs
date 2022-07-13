using MarcosCosta.Domain;
using MarcosCosta.Domain.Contracts.ExternalServices;
using MarcosCosta.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace MarcosCosta.Service
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IOnlineChallenge _onlineChallenge;
        private readonly IMemoryCache _cache;

        public VeiculoService(IOnlineChallenge onlineChallenge, IMemoryCache cache)
        {
            this._onlineChallenge = onlineChallenge;
            this._cache = cache;
        }

        public IEnumerable<MarcaEntity> GetMarcas()
        {
            var responseStream = this.GetCache("Marcas");

            if (responseStream.Result == "null")
            {
                responseStream = _onlineChallenge.Makes();
                this.SetCache("Marcas", JsonConvert.DeserializeObject<IEnumerable<MarcaEntity>>(responseStream.Result));
            }

            return this.SetResponse<MarcaEntity>(responseStream);
        }

        public IEnumerable<ModeloEntity> GetModels(int makeId)
        {
            var key = $"Modelo-{makeId}";
            var responseStream = this.GetCache(key);

            if (responseStream.Result == "null")
            {
                responseStream = _onlineChallenge.Models(makeId);
                this.SetCache(key, JsonConvert.DeserializeObject<IEnumerable<ModeloEntity>>(responseStream.Result));
            }

            return this.SetResponse<ModeloEntity>(responseStream);
        }

        public IEnumerable<VersaoEntity> GetVersions(int modelId)
        {
            var key = $"Versao-{modelId}";
            var responseStream = this.GetCache(key);

            if (responseStream.Result == "null")
            {
                responseStream = _onlineChallenge.Versions(modelId);
                this.SetCache(key, JsonConvert.DeserializeObject<IEnumerable<VersaoEntity>>(responseStream.Result));
            }

            return this.SetResponse<VersaoEntity>(responseStream);
        }

        private IEnumerable<TOut> SetResponse<TOut>(Task<string> responseStream)
        {
            if (responseStream.Result != null)
                return JsonConvert.DeserializeObject<IEnumerable<TOut>>(responseStream.Result);
            else
                return new List<TOut>();
        }

        private Task<string> GetCache(string key) => Task.Run(() => JsonConvert.SerializeObject(_cache.Get(key)));

        private void SetCache<T>(string key, T items) => _cache.Set(key, items);
    }
}

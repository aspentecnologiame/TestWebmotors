using MarcosCosta.Domain.Contracts.ExternalServices;
using MarcosCosta.Domain.Contracts.Repositories;
using MarcosCosta.Domain.Contracts.Services;
using MarcosCosta.Infra.ExternalServices.OnlineChallenges;
using MarcosCosta.Infra.Repositories.SQL;
using MarcosCosta.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarcosCosta.Infra.CrossCutting.Extensions
{
    public static class APIExtensions
    {
        public static void AddApiService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IAnuncioWebmotorsService, AnuncioWebmotorsService>();
            services.AddSingleton<IVeiculoService, VeiculoService>();
            services.AddSingleton<IOnlineChallenge, OnlineChallenge>();

            services.AddSingleton<IAnuncioWebmotorsRepository>(provider => new AnuncioWebmotorsRepository(configuration.GetConnectionString("DataBase")));
        }
    }
}

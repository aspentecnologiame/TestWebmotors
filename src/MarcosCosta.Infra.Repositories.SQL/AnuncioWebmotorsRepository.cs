using MarcosCosta.Domain;
using MarcosCosta.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace MarcosCosta.Infra.Repositories.SQL
{
    public class AnuncioWebmotorsRepository : BaseRepository, IAnuncioWebmotorsRepository
    {
        public AnuncioWebmotorsRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<AnuncioWebmotorsEntity> GetAll()
        {
            using (var connection = new SqlConnection(base.StringConnection))
            {
                return connection.Query<AnuncioWebmotorsEntity>(AnuncioWebmotorsRepositoryBuilder.GetAll);
            }
        }

        public bool Insert(AnuncioWebmotorsEntity anuncioWebmotorsEntity)
        {
            using (var connection = new SqlConnection(base.StringConnection))
            {
                return connection.ExecuteScalar<bool>(AnuncioWebmotorsRepositoryBuilder.Insert, anuncioWebmotorsEntity);
            }
        }
    }
}

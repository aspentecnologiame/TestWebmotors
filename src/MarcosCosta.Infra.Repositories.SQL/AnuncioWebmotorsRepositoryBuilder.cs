using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosCosta.Infra.Repositories.SQL
{
    public static class AnuncioWebmotorsRepositoryBuilder
    {
        public static string GetAll { get { return @"SELECT [ID], [Marca], [Modelo], [Versao], [Ano], [Quilometragem], [Observacao] FROM [AnuncioWebmotors] (nolock)"; } }

        public static string Insert { get { return @"INSERT INTO [AnuncioWebmotors] ([Marca], [Modelo], [Versao], [Ano], [Quilometragem], [Observacao]) VALUES 
                                                                                       (@Marca, @Modelo, @Versao, @Ano, @Quilometragem, @Observacao)"; } }
    }
}

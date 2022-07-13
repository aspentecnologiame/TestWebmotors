using System;

namespace MarcosCosta.Infra.Repositories.SQL
{
    public abstract class BaseRepository
    {
        public string StringConnection { get; private set; }

        public BaseRepository(string stringConnection)
        {
            this.StringConnection = stringConnection;
        }

    }
}

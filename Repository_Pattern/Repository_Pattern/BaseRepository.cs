using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Repository_Pattern
{
    public abstract class BaseRepository<T> : IDisposable where T : Entity
    {
        protected const string ConnectionString = "Server = DESKTOP-P2840GD; Database = Rokomari; Trusted_Connection = true;";
        protected SqlConnection Connection = null;

        public BaseRepository()
        {
             Connection = new SqlConnection(ConnectionString);
        }

        public abstract void Create(T item);
        public abstract void Read();
        public abstract void Update(T item);
        public abstract void Delete(T item);

        public SqlParameter Parameter(string ParameterName, SqlDbType Type, dynamic Entity)
        {
            var Para = new SqlParameter(ParameterName, Type);
            Para.Value = Entity;
            return Para;
        }

        public void Dispose()
        {
            if (Connection != null)
            {
                Connection.Dispose();
            }
        }
    }
}

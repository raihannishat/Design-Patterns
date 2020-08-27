using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TodoList.Library
{
    public abstract class Repository<T> : IDisposable where T : Task
    {
        protected readonly string connectionString;
        protected SqlConnection connection = null;

        public Repository()
        {
            connectionString = "Server = DESKTOP-P2840GD; " +
                               "Database = TodoList; " +
                               "Trusted_Connection = true;";

            connection = new SqlConnection(connectionString);
        }

        public abstract void Create(T Entity);
        public abstract void Read(T Entity);
        public abstract void Update(T Entity);
        public abstract void Delete(T Entity);

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}

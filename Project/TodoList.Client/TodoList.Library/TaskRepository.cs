using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConsoleTables;

namespace TodoList.Library
{
    public class TaskRepository : Repository<Task>
    {
        private SqlBuilder sqlBuilder = new SqlBuilder(); 

        public override void Create(Task Entity)
        {
            string query = sqlBuilder.GetInsertSql(Entity);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public override void Delete(Task Entity)
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Update(Task Entity)
        {
            throw new NotImplementedException();
        }
    }
}

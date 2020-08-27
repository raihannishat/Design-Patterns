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
        private SqlBuilder sqlBuilder = null;

        public TaskRepository()
        {
            sqlBuilder = new SqlBuilder();
        }

        public override void Create(Task Entity)
        {
            string query = sqlBuilder.GetInsertSql(Entity);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public override void Delete(Task Entity)
        {
            string query = sqlBuilder.GetDeleteSql(Entity);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public override void Read(Task Entity)
        {
            IList<Task> tasks = new List<Task>();
            Task task = new Task();
            string query = sqlBuilder.GetSelectSql(Entity);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                task.id = sqlDataReader["ID"].ToString();
                task.name = sqlDataReader["Name"].ToString();
                task.note = sqlDataReader["Note"].ToString();
                task.time = (DateTime)sqlDataReader["DateTime"];
                tasks.Add(task);
            }

            ConsoleTable consoleTable = new ConsoleTable("ID", "Name", "Note", "Time");

            foreach (var item in tasks)
            {
                consoleTable.AddRow(item.id, item.name, item.note, item.time);
            }

            consoleTable.Write();
        }

        public override void Update(Task Entity)
        {
            string query = sqlBuilder.GetUpdateSql(Entity);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}

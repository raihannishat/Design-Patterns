using System;
using TodoList.Library;

namespace TodoList.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlBuilder();
            var task = new Task() { id = "SE-311", name = "Exam", note = "Design Pattern" };

            Console.WriteLine($"{sql.GetInsertSql(task)}");
            Console.WriteLine($"{sql.GetSelectSql(task)}");
            Console.WriteLine($"{sql.GetUpdateSql(task)}");
            Console.WriteLine($"{sql.GetDeleteSql(task)}");
        }
    }
}

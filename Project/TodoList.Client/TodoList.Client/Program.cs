using System;
using TodoList.Library;

namespace TodoList.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlBuilder();

            var person = new Person() { id = "123", address = "Barisal" };

            var query = sql.GetInsertSql(person);

            Console.WriteLine(query);
        }
    }
}

using System;
using TodoList.Library;

namespace TodoList.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlBuilder();

            Product p1 = new Product() { id = "753", quantity = 9 };

            string query = sql.GetUpdateSql(p1);

            Console.WriteLine(query);
        }
    }
}

using System;
using TodoList.Library;

namespace TodoList.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlBuilder();

            var product = new Product() { id = "753", quantity = 50 };

            var task = new Task() { id = "951", note = "Sleep" };

            var query = sql.GetUpdateSql(product);

            Console.WriteLine(query);
        }
    }
}

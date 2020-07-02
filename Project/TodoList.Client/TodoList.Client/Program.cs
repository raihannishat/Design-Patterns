using System;
using TodoList.Library;

namespace TodoList.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date2 = new DateTime(2020, 7, 6, 10, 00, 00);
            //Console.WriteLine(date2.Subtract(DateTime.Now).TotalHours);
            
            var task3 = new Task() { id = "poi", name = "zxc", note = "qwe", time = DateTime.Now };

            var todo = new TaskRepository();
            todo.Create(task3);
        }
    }
}

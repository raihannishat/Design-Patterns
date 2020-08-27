using System;
using TodoList.Library;

namespace TodoList.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IToDoList toDoList = ToDoApp.GetToDoApp();
            toDoList.start();
        }
    }
}

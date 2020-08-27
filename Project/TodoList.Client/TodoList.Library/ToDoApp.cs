using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Library
{
    public class ToDoApp : IToDoList
    {
        private static ToDoApp _instance;
        CommandFactory _commandFactory = new CommandFactory();
        TaskRepository _taskRepository = new TaskRepository();

        private ToDoApp() { }

        public static ToDoApp GetToDoApp()
        {
            if (_instance == null)
            {
                _instance = new ToDoApp();
            }

            return _instance;
        }

        public void start()
        {
            Console.WriteLine("Welcome to ToDo List App");
            Console.WriteLine("====================");
            Console.WriteLine("1) Create task");
            Console.WriteLine("2) Read all task");
            Console.WriteLine("3) Update task");
            Console.WriteLine("4) Delete task");
            Console.WriteLine("5) Exit Application");
            Console.Write("Chose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("====================");
            
            if (option == 6) Environment.Exit(0);

            _commandFactory.ExecuteCommand(option, _taskRepository);
        }
    }
}

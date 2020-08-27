using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Library
{
    public class CommandFactory
    {
        private TaskRepository _taskRepository;

        public void ExecuteCommand(int option, TaskRepository taskRepository)
        {
            _taskRepository = taskRepository;

            if (option == 1)
            {
                Task _task = new Task();

                Console.Write("Name: ");
                _task.name = Console.ReadLine();

                Console.Write("Note: ");
                _task.note = Console.ReadLine();

                Console.Write("Time: ");
                _task.time = DateTime.Now;

                _taskRepository.Create(_task);
            }
            else if (option == 2)
            {
                Task _task = new Task();

                Console.WriteLine("All info from Database.");
                _taskRepository.Read(_task);
            }
            else if (option == 3)
            {
                Task _task = new Task();

                Console.Write("Name: ");
                _task.name = Console.ReadLine();

                Console.Write("Note: ");
                _task.note = Console.ReadLine();

                Console.Write("Time: ");
                _task.time = DateTime.Now;

                _taskRepository.Update(_task);
            }
            else if (option == 4)
            {
                Task _task = new Task();

                Console.Write("ID: ");
                _task.id = Console.ReadLine();

                _taskRepository.Delete(_task);
            }
            else if (option == 5)
            {
                Environment.Exit(0);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Library
{
    public class Task
    {
        public string id { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public DateTime time;

        public Task()
        {
            //Console.WriteLine(id);
        }
    }
}

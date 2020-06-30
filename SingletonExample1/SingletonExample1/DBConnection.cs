using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonExample1
{
    public class DBConnection
    {
        public DBConnection()
        {
            Console.WriteLine("Connected with DB");
        }

        public void saveData()
        {
            Console.WriteLine("Saving data");
        }

        public void getData()
        {
            Console.WriteLine("Getting data");
        }

        public void deleteData()
        {
            Console.WriteLine("Deleting data");
        }
    }
}

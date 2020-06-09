using System;
using System.Collections.Generic;
using System.Text;

namespace BasaicOOP
{
    public class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public double cgpa { get; set; }

        public Student(string id, string name, double cgpa)
        {
            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
        }

        public void takeCourse()
        {
            Console.WriteLine("Taking Course");
        }

        public void selectCredit()
        {
            Console.WriteLine("Selecting credit");
        }

        public void viewPayment()
        {
            Console.WriteLine("Viewing Payment");
        }

        public void getClearance()
        {
            Console.WriteLine("Gatting Clearance");
        }

        public void Display()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"CGPA: {cgpa}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BasaicOOP
{
    public class StudentFactory
    {
        public Student GetStudent(string option)
        {
            Student student = null;

            if (option.Equals("Local Student"))
            {
                student = new LocalStudent();
            }
            else if (option.Equals("Foreign Student"))
            {
                student = new ForeignStudent();
            }
            else
            {
                return null;
            }

            return student;
        }
    }
}

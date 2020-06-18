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

            student = option switch
            {
                "Local Student" => new LocalStudent(),
                "Foreign Student" => new ForeignStudent(),
                _ => null
            };

            return student;
        }
    }
}

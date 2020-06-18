using System;
using System.Collections.Generic;
using System.Text;

namespace BasaicOOP
{
    public class FacultyFactory
    {
        public Faculty GetFaculty(string option)
        {
            Faculty faculty = null;

            faculty = option switch
            {
                "Lecturer" => new Lecturer(),
                "Assistant Professor" => new Lecturer(),
                _ => null
            };

            return faculty;
        }
    }
}

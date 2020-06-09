using System;

namespace BasaicOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var student = new Student("182-35-2518", "Raihan Nishat", 3.56);
            //student.selectCredit();
            //student.takeCourse();
            //student.Display();

            var obj = new Moderator();
            obj.givenWaiver(new Student("182-35-2518", "Raihan Nishat", 3.56));
        }
    }
}

using System;

namespace dailyReportTechAcademy
{
    class Program
    {
        static object Main()
        {
            Console.WriteLine("The Tech Acadmey");
            Console.WriteLine();
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What page number?");
            string coursePageNo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Do you need help with anything? PLease answer" + "true" + " or " + "false." );
            string needHelp = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

            int num1 = 200 / 3;
            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}

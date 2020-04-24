using System;

namespace MathInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number between 0 and 10,000,000 and we'll multiply by 50");
            int multiplyFifty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(multiplyFifty * 50);
            Console.WriteLine();
            Console.WriteLine("Please input a number, we'll add 25");
            int addTwentyFive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(addTwentyFive + 25);
            Console.WriteLine();
            Console.WriteLine("Please input a number and we'll divide by 12.5");
            double divideTwelveFive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(divideTwelveFive / 12.5);
            Console.WriteLine();
            Console.WriteLine("Please enter a number and we'll compare it to 50");
            Console.WriteLine();
            int gtltFifty = Convert.ToInt32(Console.ReadLine());
            if (gtltFifty > 50)
            {
                Console.WriteLine("Your number was greater than 50!");
            }
            else {
                Console.WriteLine("Your number was less than 50!");
                }
            Console.WriteLine();
            Console.WriteLine("Please input a number and we'll divide by 7 and give you the modulus");
            Console.WriteLine();
            int modSeven = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(modSeven % 7);
        }
    }
}
using System;

namespace cSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            Console.Write("Please Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Pleae Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            result = num1 * num2;
            Console.WriteLine("The result of multiplying the 2 numbers is: " + result);
        }
    }
}

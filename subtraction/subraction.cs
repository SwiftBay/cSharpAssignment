using System;

namespace subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int answer = 0;

            Console.Write("Please Enter the 1st number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please Enter the 2nd number: ");
            secondNumber = int.Parse(Console.ReadLine());

            answer = firstNumber - secondNumber;
            Console.WriteLine("Subtracting the 2 number gives: " + answer);
        }
    }
}

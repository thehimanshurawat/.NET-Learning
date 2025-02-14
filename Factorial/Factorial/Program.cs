using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            long fact=1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.Write($"Factorial of a Entered number: {fact}");
        }
    }
}

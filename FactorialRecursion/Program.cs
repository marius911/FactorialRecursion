using System;

namespace FactorialRecursion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Factorial(Convert.ToInt32(Console.ReadLine())));
        }

        static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}

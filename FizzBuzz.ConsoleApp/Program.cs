using System;
using FizzBuzz.Core.FizzBuzz;

namespace FizzBuzz.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            const int start = 1;
            const int end = 100;

            var fizzBuzz = new NumberOutput()
                .SetSuccessor(new FizzBuzzOutput())
                .SetSuccessor(new FizzOutput())
                .SetSuccessor(new BuzzOutput());

            for (var i = start; i <= end; i++)
            {
                Console.WriteLine(fizzBuzz.FizzBuzzOutput(i));
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}

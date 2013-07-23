using System;
using FizzBuzz.Core.FizzBuzz;

namespace FizzBuzz.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new NumberOutput()
                .SetSuccessor(new FizzBuzzOutput())
                .SetSuccessor(new FizzOutput())
                .SetSuccessor(new BuzzOutput());

            for (var i = 1; i < 100; i++)
            {
                Console.WriteLine(fizzBuzz.FizzBuzzOutput(i));
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}

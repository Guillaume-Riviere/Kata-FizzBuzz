using System;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                string output = fizzBuzz.FizzBuzzShow(i);
                Console.WriteLine(output);
            }
        }
    }
}

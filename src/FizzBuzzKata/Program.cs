﻿using System;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 15; i = i + 1)
            {

                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                       Console.WriteLine("Fizz"); 
                    }
                    
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}

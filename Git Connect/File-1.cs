using System;
using System.Collections.Generic;

namespace BasicMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Console.WriteLine("--- Prime Numbers from 1 to 100 ---");
            FindPrimes(1, 100);
            Console.WriteLine("\n");

         
            Console.WriteLine("--- Multiples of 8 from 1 to 80 ---");
            FindMultiples(8, 80);
            Console.WriteLine("\n");

   
            Console.WriteLine("--- Multiples of 10 from 1 to 100 ---");
            FindMultiples(10, 100);
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }


        static void FindPrimes(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

 
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

     
        static void FindMultiples(int divisor, int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                if (i % divisor == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

using System;

namespace NumberClassification
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("--- Numbers from 1 to 100 ---");
            PrintRange(1, 100);
            Console.WriteLine("\n");

       
            Console.WriteLine("--- Even Numbers from 1 to 100 ---");
            PrintEvenNumbers(1, 100);
            Console.WriteLine("\n");

   
            Console.WriteLine("--- Odd Numbers from 1 to 100 ---");
            PrintOddNumbers(1, 100);

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }


        static void PrintRange(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
        }


        static void PrintEvenNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }


        static void PrintOddNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

using System;

namespace ThirdQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construa a tabuada de um número. (ex: 1x1=1, 1x2=2,...,1x10=10);
            Console.Write("Enter a number for the multiplication table: ");
            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number}x{i}={number*i}");
            }
        }
    }
}
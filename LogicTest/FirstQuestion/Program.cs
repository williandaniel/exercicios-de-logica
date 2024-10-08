using System;

namespace FirstQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia um número até que o usuário digite 10;
            int number = 0;
            UserNumber us;

            while (number != 10)
            {     
                try
                {
                    Console.Write("Enter a positive integer: ");
                    number = int.Parse(Console.ReadLine());
                    us = new UserNumber(number);
                }
                catch (IntException e)
                {
                    Console.WriteLine("Error in input format: " + e.Message);
                }
            }
        }
    }
}

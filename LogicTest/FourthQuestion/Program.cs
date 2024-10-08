using System;
using System.Collections.Generic;
using System.Linq;

namespace FourthQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gere 10 números aleatórios entre 0 e 100;
            // mostre todos na tela (em uma única linha);
            // identifique o menor e o maior deles;

            Random random = new Random();
            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (uniqueNumbers.Count < 10)
            {
                int randomNumber = random.Next(0, 101);
                uniqueNumbers.Add(randomNumber);
            }

            int minNumber = uniqueNumbers.Min();
            int maxNumber = uniqueNumbers.Max();

            foreach (int uniqueNumber in uniqueNumbers)
            {
                Console.Write(uniqueNumber + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Minimum number: " + minNumber);
            Console.WriteLine("Max number: " + maxNumber);

        }
    }
}

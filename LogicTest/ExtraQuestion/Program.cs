using System;
using ExtraQuestion.Entities;
using ExtraQuestion.Entities.Exceptions;
using System.Globalization;

namespace ExtraQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            // **Para cada produto informado(nome, preço e quantidade), escreva o nome do produto comprado
            // e o valor total a ser pago, considerando que são oferecidos descontos pelo número de
            // unidades compradas, segundo a tabela abaixo: a.Até 10 unidades: valor total
            // b.De 11 a 20 unidades: 10 % de desconto c. De 21 a 50 unidades: 20 % de desconto
            // d. Acima de 50 unidades: 25 % de desconto 3);

            try
            {
                Console.Write("Informe o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Informe o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Informe a quantidade desse produto que sera comprado: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(name, price, quantity);

                Console.WriteLine(product);
            }
            catch (ProductException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

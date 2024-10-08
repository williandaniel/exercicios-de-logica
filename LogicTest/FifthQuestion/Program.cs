using System;
using FifthQuestion.Entities;
using FifthQuestion.Entities.Enums;
using FifthQuestion.Entities.Exceptions;

namespace FifthQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implemente um jogo Jokenpo (Pedra, papel ou tesoura). Será o jogador contra a máquina.
            // O código tem que gerar as posições aleatoriamente e comparar com o que escolhemos;

            Console.WriteLine("JOGO JOKENPO");
            while (true)
            {
                try
                {
                    Console.WriteLine("Escolha um dos números abaixo:");
                    Console.Write("1 - Pedra, 2 - Papel, 3 - Tesoura: ");
                    JokenpoOption userOption = Enum.Parse<JokenpoOption>(Console.ReadLine());

                    Jokenpo jokenpo = new Jokenpo(userOption);

                    Console.WriteLine(jokenpo);
                    break;
                }
                catch (OptionException e)
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
}
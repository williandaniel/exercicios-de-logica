using System;

namespace SecondQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir a idade de uma pessoa e verificar se ela é maior de idade ou não;

            try
            {
                Console.Write("Enter the person's age: ");
                int age = int.Parse(Console.ReadLine());

                Person person = new Person(age);

                Console.WriteLine(person);
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}

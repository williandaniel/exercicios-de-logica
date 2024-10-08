using System;
using FifthQuestion.Entities.Enums;

namespace FifthQuestion.Entities
{
    class ComputerMove
    {
        private Random random;

        public ComputerMove()
        {
            random = new Random();
        }

        public JokenpoOption GetComputerMove()
        {
            int randomValue = random.Next(1, 4);
            return (JokenpoOption)randomValue;
        }
    }
}

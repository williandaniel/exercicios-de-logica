using System;


namespace FirstQuestion
{
    internal class UserNumber
    {
        public int InputNumber { get; private set; }

        public UserNumber(int inputNumber)
        {
            if (inputNumber < 0)
            {
                throw new IntException("The number must be positive");
            }

            InputNumber = inputNumber;
        }


    }
}

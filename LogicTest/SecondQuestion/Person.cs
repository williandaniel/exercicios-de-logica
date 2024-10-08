using System;


namespace SecondQuestion
{
    struct Person
    {
        public int Age { get; private set; }

        public Person(int age)
        {
            if (age < 0)
            {
                throw new AgeException("A person's age cannot be negative");
            }

            Age = age;
        }

        public string LegalAge()
        {
            if (Age >= 18)
            {
                return "of legal age";
            }
            else
            {
                return "underage";
            }
        }

        public override string ToString()
        {
            return "Person aged "
                + Age.ToString()
                + " is "
                + LegalAge()
                + "!";
        }
    }
}

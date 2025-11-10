using System;

namespace Task5
{
    public class Ifelse
    {
        public void IfElse()
        {
            int age = 10;

            if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if (age > 13 && age <= 19)
            {
                Console.WriteLine("Teenage");
            }
            else
            {
                Console.WriteLine("Adult");
            }
        }
    }
}

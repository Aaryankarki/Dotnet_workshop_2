using System;

namespace Task5;

public class SwitchCase
{  
        public void sh()
        {
            int age = 10;

            switch (age)
            {
                case < 13:
                    Console.WriteLine("You are a child");
                    break;

                case >= 13 and <= 19:
                    Console.WriteLine("Teenage");
                    break;

                default:
                    Console.WriteLine("Adult");
                    break;
            }
        }
    }





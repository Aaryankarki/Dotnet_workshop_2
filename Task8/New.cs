using System;

namespace Task8
{
    public class New
    {
        public static void Main()
        {
            // Try Catch Finally
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
            }
            catch
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

            // Throw Exception
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement");
            }
        }
    }
}

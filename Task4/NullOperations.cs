using System;

namespace Task4
{
    public class NullOperations
    {
        public void PerformNullChecks()
        {
  
            string? username = null;

            string ternaryResult = (username == null) ? "Username is not available" : username;
            Console.WriteLine(ternaryResult);


            string result2 = username ?? "Default User";
            Console.WriteLine(result2);

           
            username ??= "Assigned User";
            Console.WriteLine(username);
            
        }
    }
}

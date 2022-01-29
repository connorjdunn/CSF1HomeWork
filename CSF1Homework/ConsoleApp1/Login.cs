using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {

            Console.Title = "Login";

            for (int i = 0; i < 3; i++)
            {
            Console.Write("Login\nusername: ");
            string userName = Console.ReadLine().ToLower();
  
            if (userName == "correct username")
            {
                Console.WriteLine("You have been granted access.");
                    break;//breaks you out of loop
            }

            else if ( userName != "correct username")
            {
                Console.WriteLine("You have been denied access.");
            if (i == 2)
            {
                Console.WriteLine("You have been locked out.");

            }
            }
            
            }
            
        }//end Main()
    }//end class
}//end namespace

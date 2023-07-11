using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace username
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
         Again:
            Console.WriteLine("Enter User Name");
            userName=Console.ReadLine();

            if (userName.Length >= 6)
            {
                Console.WriteLine("Welcome: it " + userName);
            }
            else
            {

                Console.WriteLine("Invalid User Name"); 
                goto Again;
            }
            Console.ReadKey();
        }
    }
}

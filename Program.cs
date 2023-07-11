using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace username
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 10; i++)
            {
                if (i == 6)
                {
                    goto end;
                }
                Console.WriteLine("i value:{0}", i);
            }
        end: Console.WriteLine("The End");
            Console.ReadKey();

        }
    }
}

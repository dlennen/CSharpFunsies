using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string ageAsString = Console.ReadLine();
            int actualAge = int.Parse(ageAsString);

            if (actualAge < 18)
            {
                Console.WriteLine("Hey there kid.");
            }
            else
            {
                Console.WriteLine("Hello peer.");
            }

            if(actualAge > 18 && actualAge < 65)
            {
                Console.WriteLine("And condition);
            }

            if (actualAge < 18 || actualAge > 25)
            {
                Console.WriteLine("Or condition);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling on a scale of 1-5?");
            string feeling = Console.ReadLine();
            int input = int.Parse(feeling);

            switch(input)
            {
                case 1:
                    Console.WriteLine("Terrible");
                    break;
                case 2:
                    Console.WriteLine("Oh no");
                    break;
                case 3:
                    Console.WriteLine("Neutral");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Great");
                    break;
                default:
                    Console.WriteLine("That is out of range");
                    break;
            }
            Console.ReadLine();
        }
    }
}

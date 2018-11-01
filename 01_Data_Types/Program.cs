using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Ctrl+K+C) to comment chunks
            //(Ctrl+K+U) to uncomment chunks
            //int age = 23;

            bool isTall = true;

            byte high = 255;

            float floating = 123.4567f;
            double number = 123.456d;
            decimal number2 = 12345.35123m;

            //Int16 == short
            //Int64 == long

            char character = 'a';
            string word = "This is a string.";

            // Console.WriteLine(word);

            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("You entered " + name);

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("You entered " + lastName);

            Console.WriteLine("What is your age?");
            string  age = Console.ReadLine();
            Console.WriteLine("You entered " + age);

            Console.WriteLine("What is your email?");
            string email = Console.ReadLine();
            Console.WriteLine("You entered " + email);

            int myIntAge = int.Parse(age);
            myIntAge = Convert.ToInt32(age);
            Console.ReadLine();
        }
    }
}

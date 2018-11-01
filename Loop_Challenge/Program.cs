using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo insurance!");

            string menuStatus = "U";
            string name = "";
            int age = 0;
            int mileage = 0;
            string accident = "";

            while (menuStatus != "R" && menuStatus != "X")
            {
                if (menuStatus == "U")
                {

                    Console.WriteLine("What is your name?");
                    name = Console.ReadLine();

                    Console.WriteLine("How old are you?");
                    string ageAsString = Console.ReadLine();
                    age = int.Parse(ageAsString);

                    Console.WriteLine("What is the mileage on your vehicle?");
                    string mileageAsString = Console.ReadLine();
                    mileage = int.Parse(mileageAsString);

                    Console.WriteLine("Have you had an accident with this vehicle? 'yes' or 'no'");
                    accident = Console.ReadLine();
                }

                Console.WriteLine("Here is the information you have provided us:");
                Console.WriteLine($"What is your name? {name}");
                Console.WriteLine($"How old are you? {age}");
                Console.WriteLine($"What is the mileage on your vehicle? {mileage}");
                Console.WriteLine($"Have you had an accident with this vehicle? {accident}");


                decimal premium = 75m;

                if (age < 25)
                {
                    premium += 50;
                }

                if (mileage > 50000)
                {
                    premium += 25;
                    if (mileage > 100000)
                    {
                        premium += 25;
                    }
                }

                if (accident == "yes")
                {
                    premium += 25;
                }

                Console.WriteLine($"Given the information you have provided us, your monthly premium would be ${premium}.");

                Console.WriteLine("What would you like to do next?");
                Console.WriteLine("Select 'R' to register for our auto insurance.");
                Console.WriteLine("Select 'I' to review the information you have provided.");
                Console.WriteLine("Select 'U' to update your information.");
                Console.WriteLine("Select 'X' to exit this page.");

                premium = 0;

                menuStatus = Console.ReadLine();

                switch (menuStatus)
                {
                    case "R":
                        Console.WriteLine("You have registered for Komodo auto insurance!");
                        Console.ReadLine();
                        break;
                    case "I":
                        break;
                    case "U":
                        break;
                    case "X":
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Please enter another value");
                        break;
                }
            }
        }
    }
}

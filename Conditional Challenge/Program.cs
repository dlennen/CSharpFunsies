using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("In years, how old is your car?");
            string carAgeAsString = Console.ReadLine();
            int carAge = int.Parse(carAgeAsString);

            Console.WriteLine("What is the mileage on your car?");
            string mileageAsString = Console.ReadLine();
            int mileage = int.Parse(mileageAsString);

            decimal premium;

            if(carAge < 5)
            {
                premium = 75m;
            }
            else if(carAge <= 15)
            {
                premium = 100m;
            }
            else
            {
                premium = 150m;
            }

            if(mileage > 50000)
            {
                premium = premium + 25;
            }

            Console.WriteLine("Hello " + name + ", your premium for this car is $" + premium);

            Console.ReadLine();

        }
    }
}

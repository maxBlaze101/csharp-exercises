using System;

namespace MilesDriven
{
    class Program
    {
        static void Main(string[] args)
        {
            int milesDriven, gallonsUsed;
            double mileage = 0.0;
            int sumMiles = 0;
            int sumGallons = 0;
            string quit = "1";
            int counter = 1;

            while(quit != "0")
            {
                Console.WriteLine("Please enter miles driven: #{0} ", counter);
                milesDriven = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter gallons used: #{0}", counter);
                gallonsUsed = Convert.ToInt32(Console.ReadLine());

                sumMiles += milesDriven;
                sumGallons += gallonsUsed;

                Console.WriteLine("Press '0' to stop entering values, or any key to continue.");
                quit = Console.ReadLine();
                counter++;
            }
            mileage = Convert.ToDouble(sumMiles) / sumGallons;
            Console.WriteLine("The mileage is {0:N} miles per gallon.", mileage);

            Console.ReadLine();
        }
    }
}

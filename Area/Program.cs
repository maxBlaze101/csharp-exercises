using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            do
            {
                Console.WriteLine("Enter the radius of a circle to continue: ");
                try
                {
                    double r = Double.Parse(Console.ReadLine());
                    if (r > 0)
                    {
                        double area = 3.14 * r * r;
                        Console.WriteLine($"The area of the circle is: {area} ");
                    }
                    else if (r <= 0)
                    {
                        Console.WriteLine($"The radius, {r}, must be a positive number");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid character");
                }
            }
            while (n > 0);
        }
    }
}

using System;

namespace AreaofRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle Area: A (area) = L (length) x W (width)
            Console.Write("Please write the length of your rectangle: ");
            decimal lengthside = decimal.Parse(Console.ReadLine());
            Console.Write("Please enter the width of your rectangle: ");
            decimal widthSide = decimal.Parse(Console.ReadLine());

            decimal area = lengthside * widthSide;
            Console.WriteLine("The area of your rectangle is: {0}",area);
        }
    }
}

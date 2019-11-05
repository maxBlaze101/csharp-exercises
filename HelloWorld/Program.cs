using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Please enter your name:");
            name = Console.ReadLine();

            //Print
            Console.WriteLine("Hello World! Hello {0}.",name);
            //Console.ReadLine();
            Console.ReadLine();
        }
    }
}

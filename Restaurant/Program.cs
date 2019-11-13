using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max's tasty menu!");
            var menu = new Menu();
            menu.AddMenuItem(new MenuItem("Hamburger", .99, "Mystery meat in link form.", "Main Course", false));
            menu.AddMenuItem(new MenuItem("Mac n Cheese", 1.99, "Macoroni and cheese powder.", "Side", false));
            menu.AddMenuItem(new MenuItem("Humus and Pita", 3, "Freshly made humus with pita.", "Appetizer", true));

            foreach (var menuItem in menu.MenuItems)
            {
                Console.WriteLine(menuItem);
            }

            Console.ReadKey();
        }
    }
}
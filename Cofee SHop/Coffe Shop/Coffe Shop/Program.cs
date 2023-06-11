using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffe_Shop.BL;

namespace Coffe_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a CoffeeShop instance
            CoffeeShop coffeeShop = new CoffeeShop("My Coffee Shop");

            
            MenuItem item1 = new MenuItem("Cappuccino", "drink", 3.99d);
            MenuItem item2 = new MenuItem("Croissant", "food", 2.49d);
            MenuItem item3 = new MenuItem("Espresso", "drink", 2.99d);

          
            coffeeShop.AddMenuItem(item1);
            coffeeShop.AddMenuItem(item2);
            coffeeShop.AddMenuItem(item3);

            Console.WriteLine(coffeeShop.AddOrder("Cappuccino"));
            Console.WriteLine(coffeeShop.AddOrder("Croissant"));
            Console.WriteLine(coffeeShop.AddOrder("Muffin"));  // This item is not on the menu

            Console.WriteLine(coffeeShop.FulfillOrder());
            Console.WriteLine(coffeeShop.FulfillOrder());

            
            List<string> orders = coffeeShop.ListOrders();
            if (orders != null)
            {
                Console.WriteLine("Orders:");
                foreach (string order in orders)
                {
                    Console.WriteLine(order);
                }
            }
            else
            {
                Console.WriteLine("No orders.");
            }

            
            double dueAmount = coffeeShop.DueAmount();
            Console.WriteLine($"Due amount: ${dueAmount}");

           
            string cheapestItem = coffeeShop.CheapestItem();
            Console.WriteLine($"Cheapest item: {cheapestItem}");

            List<string> drinks = coffeeShop.DrinksOnly();
            Console.WriteLine("Drinks:");
            foreach (string drink in drinks)
            {
                Console.WriteLine(drink);
            }

           
            List<string> food = coffeeShop.FoodOnly();
            Console.WriteLine("Food:");
            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}

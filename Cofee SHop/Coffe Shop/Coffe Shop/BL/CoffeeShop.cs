using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop.BL
{
    class CoffeeShop
    {
        public string Name { get; }
        public List<MenuItem> Menu { get; }
        public List<string> Orders { get; }

        public CoffeeShop(string name)
        {
            Name = name;
            Menu = new List<MenuItem>();
            Orders = new List<string>();
        }

        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }

        public string AddOrder(string itemName)
        {
            MenuItem item = Menu.FirstOrDefault(i => i.Name == itemName);
            if (item != null)
            {
                Orders.Add(itemName);
                return $"Added {itemName} to the orders.";
            }

            return "This item is currently unavailable!";
        }

        public string FulfillOrder()
        {
            if (Orders.Count > 0)
            {
                string itemName = Orders[0];
                Orders.RemoveAt(0);
                return $"The {itemName} is ready!";
            }

            return "All orders have been fulfilled!";
        }

        public List<string> ListOrders()
        {
            if (Orders.Count > 0)
            {
                return Orders;
            }

            return null;
        }

        public double DueAmount()
        {
            double totalAmount = 0;
            foreach (string itemName in Orders)
            {
                MenuItem item = Menu.FirstOrDefault(i => i.Name == itemName);
                if (item != null)
                {
                    totalAmount += item.Price;
                }
            }

            return totalAmount;
        }

        public string CheapestItem()
        {
            MenuItem cheapestItem = Menu.OrderBy(i => i.Price).FirstOrDefault();
            if (cheapestItem != null)
            {
                return cheapestItem.Name;
            }

            return null;
        }

        public List<string> DrinksOnly()
        {
            return Menu.Where(i => i.Type == "drink").Select(i => i.Name).ToList();
        }

        public List<string> FoodOnly()
        {
            return Menu.Where(i => i.Type == "food").Select(i => i.Name).ToList();
        }
    }
}

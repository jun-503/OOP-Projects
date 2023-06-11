using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop.BL
{
    class MenuItem
    {
        public string Name { get; }
        public string Type { get; }
        public double Price { get; }

        public MenuItem(string name, string type, double price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
    }
}

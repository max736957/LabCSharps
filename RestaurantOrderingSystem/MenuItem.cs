using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public abstract class MenuItem
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        protected MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract string GetDescription();
        
    }



}

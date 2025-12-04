using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Dish : MenuItem
    {
        public string Category  { get; set; }
        public int Weight { get; set; }
        public int Calories { get; set; }
       public Dish(string name, double price, string category, int weight, int calories) : base(name, price)
        {
            Category = category;
            Weight = weight;
            Calories = calories;
        }

        public override string GetDescription()
        {
            return $"{Name} ({Category}, {Weight}г, {Calories} ккал) - {Price} грн";
        }
    }
}

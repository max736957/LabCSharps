using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Drink : MenuItem
    {
        public double Volume { get; set; }
        public bool IsAlcoholic { get; set; }
        public bool IsCarbonated { get; set; }
        public Drink(string name, double price, double volume, bool isAlcoholic, bool isCarbonated) : base(name, price)
        {
            Volume = volume;
            IsAlcoholic = isAlcoholic;
            IsCarbonated = isCarbonated;
        }
        public override string GetDescription()
        {
            string alcoholic = IsAlcoholic ? "з алкоголем" : "без алокоголю";
            string carbonated = IsCarbonated ? "газований" : "негазований";
            return $"{Name} ({Volume}мл {alcoholic}, {carbonated}) - {Price} грн";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Restaurant
    {
        public List<MenuItem> Menu { get;} = new List<MenuItem>();
        public List<Order> Orders { get;} = new List<Order>();

        public void AddToMenu(MenuItem item)
        {
            Menu.Add(item);
        }
        public void ShowMenu()
        {
            Console.WriteLine("\n --- МЕНЮ РЕСТОРАНУ ---");
            foreach (var item in Menu)
            {
                Console.WriteLine(item.GetDescription());
            }
            Console.WriteLine("-----------------------\n");
        }
        public Order CreateOrder(int tableNumber)
        {
            var order = new Order(tableNumber);
            Orders.Add(order);
            Console.WriteLine($"Створено нове замовлення для столика №{tableNumber}");
            return order;
        }
        public void ShowAllOrders()
        {
            Console.WriteLine("\n--- УСІ ЗАМОВЛЕННЯ ---");
            foreach (var order in Orders)
            {
                order.PrintInfo();
            }
            Console.WriteLine("-----------------------\n");
        }
        public Order FindOrderById(int id )
        {
            foreach (var o in Orders)
            {
                if (o.Id == id)
                {
                    return o; 
                }
            }
            return null; 
        }
        public List<MenuItem> FindMenuItemsByKeyword(string keyword)
        {
            List<MenuItem> found = new List<MenuItem>();
            string lowerKeyword = keyword.ToLower();

            foreach (var m in Menu)
            {
                if (m.Name.ToLower().Contains(lowerKeyword))
                {
                    found.Add(m);
                }
            }

            return found;
        }
    }
}

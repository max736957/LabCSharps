using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Order
    {
        public static int nextId = 1;
        private List<MenuItem> _items = new List<MenuItem>();

        public int Id { get; }
        public int TableNumber { get; }
        public OrderStatus Status { get; private set; }

        public Order(int tableNumber)
        {
            TableNumber = tableNumber;
            Id = nextId++;
            Status = OrderStatus.New;
        }

        public void AddItem(MenuItem item)
        {
            _items.Add(item);
            Console.WriteLine($"Додано позицію: {item.Name}");

        }
        public void RemoveItem(string name)
        {
            MenuItem item = null;

            foreach (var i in _items)
            {
                if (i.Name == name)
                {
                    item = i; 
                    break;
                }
            }
            if (item != null)
            {
                _items.Remove(item);
                Console.WriteLine($"Видалено позицію: {item.Name}");
            }
            else
            {
                Console.WriteLine("Такої позиції у замовленні немає!");
            }
        }
        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var item in _items)
            {
                total += item.Price;
            }
            return total;
        }
        public void ChangeStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"> Зміненно статус замовлення: {Status}");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Чек: {GetTotalPrice()} грн");
        }
    }
}

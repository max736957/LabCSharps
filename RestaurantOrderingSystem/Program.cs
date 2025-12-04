namespace RestaurantOrderingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant();

            restaurant.AddToMenu(new Dish("Борщ", 120, "Перше", 350, 250));
            restaurant.AddToMenu(new Dish("Салат Цезар", 150, "Салат", 200, 180));
            restaurant.AddToMenu(new Dish("Пельмені", 200, "Головне", 400, 500));
            restaurant.AddToMenu(new Dish("Тірамісу", 100, "Десерт", 150, 300));

            restaurant.AddToMenu(new Drink("Кава", 60, 200, false, false));
            restaurant.AddToMenu(new Drink("Кола", 50, 330, false, true));
            restaurant.AddToMenu(new Drink("Вино", 120, 150, true, false));
            restaurant.AddToMenu(new Drink("Сік апельсиновий", 70, 250, false, false));

            restaurant.ShowMenu();

            Order order1 = restaurant.CreateOrder(5);
            order1.AddItem(restaurant.Menu[0]); 
            order1.AddItem(restaurant.Menu[4]); 
            Console.WriteLine($"Поточна сума: {order1.GetTotalPrice()} грн");
            order1.ChangeStatus(OrderStatus.InProgress);
            order1.ChangeStatus(OrderStatus.Ready);
            order1.ChangeStatus(OrderStatus.Paid);

            Order order2 = restaurant.CreateOrder(3);
            order2.AddItem(restaurant.Menu[1]); 
            order2.AddItem(restaurant.Menu[5]); 
            order2.AddItem(restaurant.Menu[7]);
            Console.WriteLine($"Поточна сума: {order2.GetTotalPrice()} грн");
            order2.ChangeStatus(OrderStatus.InProgress);
            order2.ChangeStatus(OrderStatus.Ready);

            Order order3 = restaurant.CreateOrder(7);
            order3.AddItem(restaurant.Menu[2]); 
            order3.AddItem(restaurant.Menu[6]); 
            Console.WriteLine($"Поточна сума: {order3.GetTotalPrice()} грн");
            order3.ChangeStatus(OrderStatus.InProgress);

            restaurant.ShowAllOrders();

            var foundOrder = restaurant.FindOrderById(2);
            if (foundOrder != null)
            {
                Console.WriteLine("Знайдено замовлення за ID 2:");
                foundOrder.PrintInfo();
            }

            var itemsWithK = restaurant.FindMenuItemsByKeyword("К");
            Console.WriteLine("--- Знайдено в меню ---");
            foreach (var item in itemsWithK)
            {
                Console.WriteLine(item.GetDescription());
            }

        }
    }
}

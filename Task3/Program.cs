namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть ваш вік: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                string category = ClassifyAge(age);
                Console.WriteLine(category);
            }
            else
            {
                Console.WriteLine("Невірний ввід");
            }
        }

        public static string ClassifyAge(int age)
        {
            if (age < 0 || age > 120)
                return "Нереальний вік";
            else if (age < 12)
                return "Ви дитина";
            else if (age >= 12 && age <= 17)
                return "Підліток";
            else if (age >= 18 && age <= 59)
                return "Дорослий";
            else
                return "Пенсіонер";
        }
    }
}

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть число: ");
            int number = int.Parse(Console.ReadLine());

            string message = GetMessage(number);
            Console.WriteLine(message);
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static string GetMessage(int number)
        {
            if (IsEven(number))
            {
                return "Двері відкриваються!";
            }
            else
            {
                return "Двері зачинені...";
            }
        }
    }
}

namespace Task5
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[][] groups = new int[][]
            {
                new int[] { 80, 90, 70, 60, 100 },
                new int[] { 50, 60, 75, 80, 95 },
                new int[] { 90, 95, 100, 92, 97 }
            };

            PrintGroupStatistics(groups);
        }

        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return (double)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min)
                    min = mark;
            }
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark > max)
                    max = mark;
            }
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int[] group = groups[i];
                double average = GetAverage(group);
                int min = GetMin(group);
                int max = GetMax(group);

                Console.WriteLine($"Група {i + 1}: Середній = {average:F0}, Мінімальний = {min}, Максимальний = {max}");
            }
        }
    }
}

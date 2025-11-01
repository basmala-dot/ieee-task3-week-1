namespace ieee_task3_week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            int[] grades = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter name of student " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
                Console.Write("Enter grade of " + names[i] + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            double average = (grades[0] + grades[1] + grades[2]) / 3.0;

            Console.WriteLine("Average grade = " + average);
            Console.WriteLine("Students above average:");

            for (int i = 0; i < 3; i++)
            {
                if (grades[i] > average)
                    Console.WriteLine(names[i]);
            }
        }
    }
}

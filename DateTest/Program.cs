namespace DateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Set date: ");

            Console.Write("day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Date date = new Date(day, month, year);

            Console.WriteLine($"The date is {date.DisplayDate()}");
        }
    }
}
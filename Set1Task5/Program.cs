using System;

namespace Set1Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Random random = new Random();
            int number = random.Next(1, 5);
            Console.WriteLine("Random number: " +number);
            today = today.AddDays(number);
            Console.WriteLine("Date: " +today);          
        }
    }
}

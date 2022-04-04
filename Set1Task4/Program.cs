using System;

namespace Set1Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The given numbers are " +a+ " and " +b);
            int c = addValue(++a,--b);
            Console.WriteLine("Sum of given numbers are " +c);
            c = subtractionValue(++a, --b);
            Console.WriteLine("The difference of given numbers are " + c);
            c = productValue(++a, --b);
            Console.WriteLine("The product of given numbers are " + c);
            c = divisionValue(++a, --b);
            Console.WriteLine("The quotient of given numbers are " + c);
            c = remainderValue(++a, --b);
            Console.WriteLine("The remainder of given numbers are " + c);
        }

        public static int addValue(int a, int b)
        {
            Console.WriteLine("The current values of a and b are " +a+ " and " +b);
            return a+b;
        }

        public static int subtractionValue(int a, int b)
        {
            Console.WriteLine("The current values of a and b are " + a + " and " + b);
            return a-b;
        }

        public static int productValue(int a, int b)
        {
            Console.WriteLine("The current values of a and b are " + a + " and " + b);
            return a*b;
        }

        public static int divisionValue(int a, int b)
        {
            Console.WriteLine("The current values of a and b are " + a + " and " + b);
            return a/b;
        }

        public static int remainderValue(int a, int b)
        {
            Console.WriteLine("The current values of a and b are " + a + " and " + b);
            return a % b;
        }
    }
}

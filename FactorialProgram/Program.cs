using System;

namespace FactorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialExample obj = new FactorialExample();
            obj.factops();
        }
    }

    public class FactorialExample
    {
        public void factops()
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);

        }
    }
}
using System;

namespace SonarQubeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SonarQube Demo App - .NET 8");

            var calc = new Calculator();
            Console.WriteLine($"Sum: {calc.Add(10, 10)}");
            Console.WriteLine($"Sum again: {calc.Add(10, 10)}"); // Duplicate call
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            int unusedVar = 42; // Unused variable
            return a + b;
        }
    }
}

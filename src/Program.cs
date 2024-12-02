using System;

using CalculatorNS;

namespace MainNS
{
    public class Program()
    {
        public static void Main()
        {
            Console.WriteLine("hello world");
            int a = 1;
            int b = 2;
            var calculator = new Calculator();
            int sum = calculator.Add(a, b);
            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}
using CalculatorNS;

namespace MainNS
{
    public class Program()
    {
        public static void Main()
        {
            int a = 0;
            int b = 2;
            var calculator = new Calculator();
            int sum = calculator.Add(a, b);
            Console.WriteLine($"{a} + {b} = {sum}");


            int c = 0;
            float quotient = calculator.Divide(a, c);
            Console.WriteLine($"{a} / {c} = {quotient}");

        }
    }
}
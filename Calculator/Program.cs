namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Calculation.Operant();
            double b = Calculation.Operant1();
            double ad = Calculation.Addition(a, b);
            double su = Calculation.Subtraction(a, b);
            double mu = Calculation.Multiplication(a, b);
            double de = Calculation.Devision(a, b);
            Console.WriteLine($"{a} + {b} = {ad}");
            Console.WriteLine($"{a} - {b} = {su}");
            Console.WriteLine($"{a} * {b} = {mu}");
            Console.WriteLine($"{a} / {b} = {de}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculation
    {
        public static double Operant()
        {
            double i;
            do
            {
                Console.WriteLine("Operand 1:\t");
                string s = Console.ReadLine();
                double.TryParse(s, out i);
            } while(i <= 0);
            return i;
        }
        public static double Operant1()
        {
            double o;
            do
            {
                Console.WriteLine("Operand 2:\t");
                string s = Console.ReadLine();
                double.TryParse(s, out o);
            } while (o <= 0);
            return o;
        }
        public static double Addition(double a, double b)
        {
            double i;
            i = a + b;
            return i;
        }
        public static double Subtraction(double a, double b)
        {
            double i;
            i = a - b;
            return i;
        }
        public static double Multiplication(double a, double b)
        {
            double i;
            i = a * b;
            return i;
        }
        public static double Devision(double a, double b)
        {
            double i;
            i = a / b;
            return i;
        }
    }
}

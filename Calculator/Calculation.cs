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
            double i;
            do
            {
                Console.WriteLine("Operand 2:\t");
                string s = Console.ReadLine();
                double.TryParse(s, out i);
            } while (i <= 0);
            return i;
        }
        public static void Addition()
        {
            double a = Operant();
            double b = Operant1();
            double r = a + b;
            string s = "+";
            MainMethods.ZwischenSpeicher(r);
            TextCalc.Result(a, b, r, s);
        }
        public static void Substraction()
        {
            double a = Operant();
            double b = Operant1();
            double r = a - b;
            string s = "-";
            MainMethods.ZwischenSpeicher(r);
            TextCalc.Result(a, b, r, s);
        }
        public static void Multiplication()
        {
            double a = Operant();
            double b = Operant1();
            double r = a * b;
            string s = "*";
            MainMethods.ZwischenSpeicher(r);
            TextCalc.Result(a, b, r, s);
        }
        public static void Devision()
        {
            double a = Operant();
            double b = Operant1();
            double r = a / b;
            string s = "/";
            MainMethods.ZwischenSpeicher(r);
            TextCalc.Result(a, b, r, s);
        }
    }
}

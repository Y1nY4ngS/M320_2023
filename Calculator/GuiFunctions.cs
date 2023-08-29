using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class GuiFunctions
    {
        public static string MenuOeffnen()
        {

            Console.WriteLine("");
            Console.WriteLine("Bitte Operation eingeben:");
            Console.WriteLine("a für 2 Zahlen addieren");
            Console.WriteLine("s für 2 Zalhen subtrahieren ");
            Console.WriteLine("m für 2 Zalhen multiplizieren");
            Console.WriteLine("d für 2 Zahlen dividieren");
            Console.WriteLine("b für alle 4 operationen");
            Console.WriteLine("e für exit");
            string op = Console.ReadLine();
            return op;

        }
        public static void AutoExec()
        {
            double a;
            double b;
            double ad;
            double su;
            double mu;
            double de;
            while (true)
            {
                string op = MenuOeffnen();
                if (IsValidOp(op))
                {
                    switch (op)
                    {
                        case "b":
                            a = Calculation.Operant();
                            b = Calculation.Operant1();
                            ad = Calculation.Addition(a, b);
                            su = Calculation.Subtraction(a, b);
                            mu = Calculation.Multiplication(a, b);
                            de = Calculation.Devision(a, b);
                            Console.WriteLine($"{a} + {b} = {ad}");
                            Console.WriteLine($"{a} - {b} = {su}");
                            Console.WriteLine($"{a} * {b} = {mu}");
                            Console.WriteLine($"{a} / {b} = {de}");
                            break;
                        case "a":
                            a = Calculation.Operant();
                            b = Calculation.Operant1();
                            ad = Calculation.Addition(a, b);
                            Console.WriteLine($"{a} + {b} = {ad}");
                            break;
                        case "s":
                            a = Calculation.Operant();
                            b = Calculation.Operant1();
                            su = Calculation.Subtraction(a, b);
                            Console.WriteLine($"{a} - {b} = {su}");
                            break;
                        case "m":
                            a = Calculation.Operant();
                            b = Calculation.Operant1();
                            mu = Calculation.Multiplication(a, b);
                            Console.WriteLine($"{a} * {b} = {mu}");
                            break;
                        case "d":
                            a = Calculation.Operant();
                            b = Calculation.Operant1();
                            de = Calculation.Devision(a, b);
                            Console.WriteLine($"{a} / {b} = {de}");
                            break;
                        default:
                            Console.WriteLine("Operation geht nicht");
                            break;
                    }
                }
                else if (op == "e")
                {
                    Console.WriteLine("Aufwiedersehen");
                    break;
                }
                else
                {
                    Console.WriteLine(" Operation ungueltig");
                }
            }
            
        }
        private static bool IsValidOp(string op)
        {
            return op == "b" || op == "a" || op == "s" || op == "m" || op == "d";
        }
    }
}

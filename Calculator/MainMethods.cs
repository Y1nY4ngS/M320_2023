using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MainMethods
    {
        public static void SwitchCase(string op) 
        {
            if (IsValidOp(op))
            {
                switch (op)
                {
                    case "a":
                        Calculation.Addition();
                        break;
                    case "s":
                        Calculation.Substraction();
                        break;
                    case "m":
                        Calculation.Multiplication();
                        break;
                    case "d":
                        Calculation.Devision();
                        break;
                    default:
                        Console.WriteLine("Operation ungueltig");
                        break;
                }
            } else if (op == "e")
            {
                Console.WriteLine("Ciao");
            }
            WeiterRechen();
        }

        public static void SwitchCase(string op, do)
        {
            if (IsValidOp(op))
            {
                switch (op)
                {
                    case "a":
                        Calculation.Addition();
                        break;
                    case "s":
                        Calculation.Substraction();
                        break;
                    case "m":
                        Calculation.Multiplication();
                        break;
                    case "d":
                        Calculation.Devision();
                        break;
                    default:
                        Console.WriteLine("Operation ungueltig");
                        break;
                }
            }
            else if (op == "e")
            {
                Console.WriteLine("Ciao");
            }
            WeiterRechen();
        }

        public static void WeiterRechen()
        {
            int i = GuiFunctions.ZwischenMenu();
            if (i == 1)
            {
                string op = GuiFunctions.MenuFortfuerendeKalkulation();
                SwitchCase(op);
            }
            else if (i == 2)
            {
                AutoExec();
            }
            else
            {
                Console.WriteLine("ungueltige eingabe");
                Console.WriteLine("");
                GuiFunctions.ZwischenMenu();
            }
        }

        public static void ZwischenSpeicher(double r)
        {
            double i = r;
        }
        public static void AutoExec()
        {
            string op = GuiFunctions.MenuOeffnen();
            SwitchCase(op);

        }
        private static bool IsValidOp(string op)
        {
            return op == "a" || op == "s" || op == "m" || op == "d";
        }
    }
}

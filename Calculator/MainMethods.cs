using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public static void SwitchCase2(string op)
        {
            if (IsValidOp(op))
            {
                switch (op)
                {
                    case "a":
                        Calculation.Addition1();
                        break;
                    case "s":
                        Calculation.Substraction1();
                        break;
                    case "m":
                        Calculation.Multiplication1();
                        break;
                    case "d":
                        Calculation.Devision1();
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
                SwitchCase2(op);
            }
            else if (i == 2)
            {
                AutoExec();
            }
        }
        private double _zwischenSpeicher;
        public double ZwischenSpeicherZahl
        {
            get { return _zwischenSpeicher; }
            set { _zwischenSpeicher = value; }
        }
        public static double ZwischenSpeicherHolen()
        {
            
        }
        public static void ZwischenSpeicherFunktion(double i)
        {
            MainMethods myResult = new MainMethods();
            myResult.ZwischenSpeicherZahl = i;
        }
        public static void ZwischenSpeicher(double r)
        {
            double i = r;
            ZwischenSpeicherFunktion(i);
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

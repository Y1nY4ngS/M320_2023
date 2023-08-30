using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class TextCalc
    {
        public static void Result(double a, double b, double r, string s)
        {
            Console.WriteLine($"{a} {s} {b} = {r}");
        }
    }
}

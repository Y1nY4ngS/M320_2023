using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungsaufgabe_1
{
    public class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        public static int Calc_kgV(int a, int b)
        {
            return (a * b) / Calc_ggT(a, b);
        }

        public static int ReadInt()
        {
            int i;
            do
            {
                Console.WriteLine("Zahl eingeben");
                string s = Console.ReadLine();
                int.TryParse(s, out i);
            } while (i <= 0);
            Console.WriteLine("Danke");

            return i;

        }

        public static void ShowResult(string op, int a, int b, int c)
        {
            Console.WriteLine(op + " von {0} und {1} ist {2}", a, b, c);
        }

        public static string MenuOeffnen()
        {

            Console.WriteLine("");
            Console.WriteLine("Bitte Operation eingeben:");
            Console.WriteLine("g für ggT");
            Console.WriteLine("k für kgV");
            Console.WriteLine("r für ggTr");
            Console.WriteLine("e für exit");
            string op = Console.ReadLine();
            return op;

        }

        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Calc_ggT_r(b, a % b);
            }
        }

        public static void SwapInt(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}

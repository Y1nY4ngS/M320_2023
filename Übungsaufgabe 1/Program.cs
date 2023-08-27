using System.ComponentModel.Design;

namespace Übungsaufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string op = MyMath.MenuOeffnen();
                if (IsValidOp(op))
                {
                    int a = MyMath.ReadInt();
                    int b = MyMath.ReadInt();
                    int r;
                    switch (op)
                    {
                        case "g":
                            r = MyMath.Calc_ggT(a, b);
                            MyMath.ShowResult("ggT", a, b, r);
                            break;
                        case "k":
                            r = MyMath.Calc_kgV(a, b);
                            MyMath.ShowResult("kgV", a, b, r);
                            break;
                        case "r":
                            r = MyMath.Calc_ggT_r(a, b);
                            MyMath.ShowResult("ggTr", a, b, r);
                            break;
                        default:
                            Console.WriteLine("Operation geht nicht");
                            break;
                    }
                } else if (op == "e")
                {
                    Console.WriteLine("Aufwiedersehen");
                    break;
                } 
                else
                {
                    Console.WriteLine("ungültige Operation");
                }
            }
        }

        private static bool IsValidOp(string op)
        {
            return op == "g" || op == "k" || op == "r";
        }
    }
}
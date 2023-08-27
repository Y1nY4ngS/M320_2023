using System.ComponentModel.Design;

namespace Übungsaufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string de = MenuOeffnen();
                if (IstDe(de))
                {
                    int a = IntRead();
                    int b = IntRead();
                    int r;
                    switch (de)
                    {
                        case "g":
                            r = Calc_ggT(a, b);
                            ShowResult("ggT", a,b, r);
                            break;
                        case "k":
                            r = Calc_kgV(a, b);
                            ShowResult("kgV", a, b, r);
                            break;
                        case "r":
                            r = Calc_ggT_r(a, b);
                            ShowResult("ggTr", a, b, r);
                            break;
                        default:
                            Console.WriteLine("Operation geht nicht");
                            break;
                    }
                } else if (de== 'e')
                {
                    Console.WriteLine("Aufwiedersehen");
                    break;
                }
            }
            private static bool IsValidOp(string op)
            {
                return op == "g" || op == "k" || op == "r";
            }
        }
    }
}
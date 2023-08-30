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
            Console.WriteLine("e für exit");
            string op = Console.ReadLine();
            return op;

        }
        public static int ZwischenMenu()
        {
            int i;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Wollen Sie mit dem Zwischenergebnis weiter rechen?");
                Console.WriteLine("1 für ja");
                Console.WriteLine("2 für nein");
                string s = Console.ReadLine();
                int.TryParse(s, out i);
                if (i != 1 && i != 2) Console.WriteLine("ungueltige eingabe");
            } while (i !=1 && i != 2);
            return i;
        }
        public static string MenuFortfuerendeKalkulation() 
        {
            Console.WriteLine("");
            Console.WriteLine("a weiter addieren");
            Console.WriteLine("s weiter subtrahieren");
            Console.WriteLine("m weiter multiplizieren");
            Console.WriteLine("d weiter devidieren");
            string op = Console.ReadLine();
            return op;
        }
    }
}

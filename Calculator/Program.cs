using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                string op = GuiFunctions.MenuOeffnen();
                GuiFunctions.SwitchCase(op);
            }
        }
    }
}
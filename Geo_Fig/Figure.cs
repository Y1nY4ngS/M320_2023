using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Fig
{
    abstract public class Figure
    {
        protected float _xPosition;
        protected float _yPosition;

        public Figure(float x = 100f, float y = 100f)
        {
            _xPosition = x;
            _yPosition = y;
        }

        public void PrintPosition()
        {
            Console.WriteLine($"Top left corner is at X={_xPosition} and Y={_yPosition}");
        }

        abstract public void PrintArea();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Fig
{
    public class Circle : Figure
    {
        private float _radius = 10;

        public float Radius
        {
            get => _radius;
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
            }
        }

        public Circle(float x = 100f, float y = 100f) : base(x, y)
        {
        }

        public Circle(float radius, float x = 100f, float y = 100f) : this(x, y)
        {
            Radius = radius;
        }

        public new void PrintPosition()
        {
            Console.WriteLine($"Center is at X={_xPosition + _radius} and Y={_yPosition + _radius}");
        }

        public override void PrintArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"The circles area is {area}.");
        }
    }
}

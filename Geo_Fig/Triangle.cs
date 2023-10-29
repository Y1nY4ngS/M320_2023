using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Fig
{
    public class Triangle : Figure
    {
        private float _baseLength = 100;
        private float _height = 150;
        private float _rotationAngle;

        public float BaseLength
        {
            get => _baseLength;
            set => _baseLength = value > 0 ? value : 0;
        }

        public float Height
        {
            get => _height;
            set => _height = value > 0 ? value : 0;
        }

        public Triangle(float x = 100f, float y = 100f) : base(x, y)
        {
        }

        public Triangle(float baseLength, float height, float x = 100f, float y = 100f) : this(x, y)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public void R90Clockwise()
        {
            _rotationAngle += 90;
            if (_rotationAngle >= 360)
            {
                _rotationAngle = 0;
            }
        }

        public override void PrintArea()
        {
            double area = 0.5 * BaseLength * Height;
            Console.WriteLine($"The circles area is {area}.");
        }
    }
}

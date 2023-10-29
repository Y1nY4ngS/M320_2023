using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Fig
{
    public class Rectangle : Figure
    {
        protected float _width = 100;
        protected float _height = 100;

        public virtual float Width
        {
            get => _width;
            set
            {
                _height = value > 0 ? value : 0;
            }
        }

        public virtual float Height
        {
            get => _height;
            set
            {
                _height = value > 0 ? value : 0;
            }
        }

        public Rectangle(float x = 100f, float y = 100f) : base(x, y)
        {
        }

        public Rectangle(float width, float height, float x = 100f, float y = 100f) : this(x, y)
        {
            Width = width;
            Height = height;
        }

        public new void PrintPosition()
        {
            base.PrintPosition();
            Console.WriteLine($"Bottom right corner is at X={_xPosition + Width} and Y={_yPosition + Height}");
        }

        public void R90Clockwise()
        {
            // Calculate center of rectangle
            float centerX = _xPosition + 0.5f * _width;
            float centerY = _yPosition + 0.5f * _height;

            // Switch width and height
            float initialWidth = _width;
            _width = _height;
            _height = initialWidth;

            // Set new coordinates of top left corner after rotation
            _xPosition = centerX - 0.5f * _width;
            _yPosition = centerY - 0.5f * _height;
        }

        public override void PrintArea()
        {
            var area = Width * Height;
            Console.WriteLine($"The rectangles area is {area}.");
        }
    }
}

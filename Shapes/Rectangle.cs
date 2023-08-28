using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle
    {
        public int width;
        public int height;
        private readonly string id;
        private Color fillColor = Color.White;

        public int abc = 1;
        public Color LineColor
        {
            get
            {
                return Color.Black;
            }
        }
        public Point TopLeftPoint
        { get
            {
                Point point = new Point();
                point.X = 0;
                point.Y = height;
                return point;
            }
        set
            {
                width = value.X;
            }
        }
        public int Diagonal { get; }
        public Point MiddlePoint { get; set; }

        public int Area => width * height;
        public int Perimeter => 2 * (width + height);
        
        public void WriteValuesToConsole()
        {
            Console.WriteLine($"Width: {width}");        
        }

    }
}

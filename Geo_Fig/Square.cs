using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Fig
{
    public class Square : Rectangle
    {
        public override float Width
        {
            get => _width;
            set
            {
                _width = value > 0 ? value : 0;
                this.Height = value;
            }
        }

        public override float Height
        {
            get => _height;
            set
            {
                _height = value > 0 ? value : 0;
                this.Width = value;
            }
        }

        public Square(float x = 100f, float y = 100f) : base(x, y)
        {
        }

        public Square(float widthAndHeight, float x = 100f, float y = 100f) : base(widthAndHeight, widthAndHeight, x, y)
        {
        }
    }
}

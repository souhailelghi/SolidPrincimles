using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Before
{
    public class Square : Rectangle
    {
        public Square(int width, int height) : base(width, height)
        {
            this.width = width;
            this.height = height;
        }
        public override void SetWidth(int width)
        {
            base.SetWidth(width);
            base.SetHeight(width);
        }

        public override void SetHeight(int height)
        {
            base.SetWidth(height);
            base.SetHeight(height);
        }
        public override int GetArea()
        {
            return width * height;
        }
    }
}

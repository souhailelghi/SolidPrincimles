using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Before
{
    public class Rectangle
    {
        protected int width;
        protected int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }
        public virtual void SetWidth(int width)
        {
            this.width = width;
        }

        public virtual void SetHeight(int height)
        {
            this.height = height;
        }

        public virtual int GetArea()
        {
            return width * height;
        }
    }
}

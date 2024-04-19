using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.After
{
    public interface IShape
    {
        int GetWidth();
        int GetHeight();
        void SetWidth(int width);
        void SetHeight(int height);
        int Area();
    }
}

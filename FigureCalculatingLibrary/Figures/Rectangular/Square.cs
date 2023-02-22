using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculatingLibrary.Figures.Rectangular
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
            Name = "Square";
        }
    }
}

using FigureCalculatingLibrary.Figures.BasicAbstractFigures;
using FigureCalculatingLibrary.Interfaces;
using FigureCalculatingLibrary.Interfaces.FigureType;
using SquareCalculating.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculatingLibrary.Figures.Rectangular
{
    public class Rectangle : CommonMultilateralFigure, IRectangle
    {
        private double[] _sides;

        public Rectangle(params double[] sides) : base("Rectangle")
        {
            if (sides.Length != 2) throw new IncorrectFigureParametersException(nameof(Rectangle));
            Sides = sides;
        }

        public override double[] Sides
        {
            get
            {
                return _sides;
            }
            set
            {
                if (value[0] <= 0 || value[1] <= 0) throw new IncorrectFigureParametersException(nameof(Rectangle));
                _sides = value;
            }
        }

        public double[] Angles { get; } = new double[4] { 90, 90, 90, 90 };

        public override double CalculateArea()
        {
            return Sides[0] * Sides[1];
        }
    }
}

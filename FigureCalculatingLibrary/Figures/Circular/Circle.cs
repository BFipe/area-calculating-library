using FigureCalculatingLibrary.Figures.BasicAbstractFigures;
using FigureCalculatingLibrary.Interfaces.FigureType;
using SquareCalculating.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculatingLibrary.Figures.Circular
{
    public class Circle : CommonShape, ICircle
    {
        private double _radius;

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value <= 0) throw new IncorrectFigureParametersException(nameof(Circle));

                _radius = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

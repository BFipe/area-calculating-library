using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureCalculatingLibrary.Figures;
using FigureCalculatingLibrary.Figures.BasicAbstractFigures;
using FigureCalculatingLibrary.Interfaces.FigureType;
using SquareCalculating.Exceptions;

namespace FigureCalculatingLibrary.Figures.Triangular
{
    public class Triangle : CommonMultilateralFigure, ITriangle
    {
        private double[] _sides;
        private double[] _angles;

        public Triangle(params double[] sides) : base("Triangle")
        {
            if (sides.Length != 3) throw new IncorrectFigureParametersException(nameof(Triangle));

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
                if (value[0] + value[1] <= value[2]
                    || value[0] + value[2] <= value[1]
                    || value[2] + value[1] <= value[0]
                    && value[0] > 0 && value[1] > 0 && value[2] > 0)
                {
                    throw new IncorrectFigureParametersException(nameof(Triangle));
                }
                else
                {
                    _sides = value;
                    CalculateAngles();
                }
            }
        }

        public double[] Angles
        {
            get
            {
                return _angles;
            }

            private set
            {
                _angles = value;
            }
        }

        private void CalculateAngles()
        {
            double angleA = _sides[0];
            double angleB = _sides[1];
            double angleC = _sides[2];

            double[] angles = new double[3];

            angles[0] = Math.Acos((angleA * angleA + angleB * angleB - angleC * angleC) / (2 * angleA * angleB)) * 180 / Math.PI;

            angles[1] = Math.Acos((angleB * angleB + angleC * angleC - angleA * angleA) / (2 * angleB * angleC)) * 180 / Math.PI;

            angles[2] = Math.Acos((angleA * angleA + angleC * angleC - angleB * angleB) / (2 * angleA * angleC)) * 180 / Math.PI;


            Angles = angles;
        }

        public override double CalculateArea()
        {
            //Также можно было сделать по 2м сторонам и углу между ними
            double halfPerimeter = Sides.Sum(q => q) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - Sides[0]) * (halfPerimeter - Sides[1]) * (halfPerimeter - Sides[2]));
        }

        public bool IsRectangular()
        {
            //Это также можно было сделать, имея только 3 стороны, но данное улучшение
            //было добавленно для легкого правила добавления других фигур
            return Angles.Any(angle => angle == 90);
        }
    }
}

using FigureCalculatingLibrary.Interfaces.CommonShapeFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculatingLibrary.Figures.BasicAbstractFigures
{
    public abstract class CommonShape : IAreaCalculatable
    {
        public string Name { get; set; }

        public CommonShape(string name = "Shape")
        {
            Name = name;
        }

        public abstract double CalculateArea();
    }
}

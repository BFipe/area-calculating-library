using FigureCalculatingLibrary.Interfaces.ShapeTypeSeparation.BySides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculatingLibrary.Figures.BasicAbstractFigures
{
    public abstract class CommonMultilateralFigure : CommonShape, IMultilateralFigure
    {
        public CommonMultilateralFigure(string name = "MultilateralFigure") : base(name)
        {

        }

        public abstract double[] Sides { get; set; }
    }
}

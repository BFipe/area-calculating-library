using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculatingLibrary.Interfaces.ShapeTypeSeparation.ByAngles
{
    public interface IAngleDependencingFigure
    {
        public double[] Angles { get; }
    }
}

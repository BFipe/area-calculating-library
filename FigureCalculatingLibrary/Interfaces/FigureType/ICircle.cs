using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureCalculatingLibrary.Interfaces.BasicShapeDefinition;
using FigureCalculatingLibrary.Interfaces.CommonShapeFunctions;
using FigureCalculatingLibrary.Interfaces.ShapeTypeSeparation.BySides;

namespace FigureCalculatingLibrary.Interfaces.FigureType
{
    public interface ICircle : ICommonShape, IAreaCalculatable
    {
        public double Radius { get; set; }
    }
}

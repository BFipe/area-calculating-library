using FigureCalculatingLibrary.Interfaces.BasicShapeDefinition;
using FigureCalculatingLibrary.Interfaces.CommonShapeFunctions;
using FigureCalculatingLibrary.Interfaces.ShapeTypeSeparation.ByAngles;
using FigureCalculatingLibrary.Interfaces.ShapeTypeSeparation.BySides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculatingLibrary.Interfaces.FigureType
{
    public interface IRectangle : ICommonShape, IMultilateralFigure, IAreaCalculatable, IAngleDependencingFigure
    {
    }
}

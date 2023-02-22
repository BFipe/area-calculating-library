using FigureCalculatingLibrary.Interfaces.BasicShapeDefinition;
using FigureCalculatingLibrary.Interfaces.CommonShapeFunctions;
using FigureCalculatingLibrary.Interfaces.ShapeTypeSeparation.ByAngles;
using FigureCalculatingLibrary.Interfaces.ShapeTypeSeparation.BySides;

namespace FigureCalculatingLibrary.Interfaces.FigureType
{
    public interface ITriangle : ICommonShape, IMultilateralFigure, IAreaCalculatable, IAngleDependencingFigure
    {
        public bool IsRectangular();
    }
}
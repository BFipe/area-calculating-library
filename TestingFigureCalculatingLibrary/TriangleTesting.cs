using FigureCalculatingLibrary.Figures.Triangular;
using FigureCalculatingLibrary.Interfaces.CommonShapeFunctions;
using FigureCalculatingLibrary.Interfaces.FigureType;
using FigureCalculatingLibrary.Interfaces.ShapeTypeSeparation.ByAngles;
using SquareCalculating.Exceptions;


namespace TestingFigureCalculatingLibrary
{
    public class Tests
    {
        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(8, 15, 17)]
        [TestCase(6, 6, 6)]
        [TestCase(7, 7, 9)]
        public void CreatingTriangle_CorrectSideValues_SuqessfullCreating(params double[] sides)
        {
            Triangle triangle = new Triangle(sides);
            Assert.That(triangle.Name, Is.EqualTo("Triangle"));
            Assert.That(triangle.Sides, Is.EqualTo(sides));
        }

        [Test]
        [TestCase(6, 3, 4, 5)]
        [TestCase(30, 5, 12, 13)]
        [TestCase(60, 8, 15, 17)]
        [TestCase(15.59, 6, 6, 6)]
        [TestCase(24.12, 7, 7, 9)]
        public void CalculatingTriangleArea_CorrectSideValues_CorrectAreaVales(double answer, params double[] sides)
        {
            IAreaCalculatable triangle = new Triangle(sides);
            var result = triangle.CalculateArea();
            Assert.That(result, Is.EqualTo(answer).Within(0.01));
        }

        [Test]
        [TestCase(3, 4, 5, 90, 36.87, 53.13)]
        [TestCase(2, 3, 4, 104.48, 28.96, 46.57)]
        public void CalculatingTriangleAngles_CorrectSideValues_CorrectAngleVales(double side1, double side2, double side3, double correctAngle1, double correctAngle2, double correctAngle3)
        {
            IAngleDependencingFigure triangle = new Triangle(side1, side2, side3);
            var angle1 = triangle.Angles[0];
            var angle2 = triangle.Angles[1];
            var angle3 = triangle.Angles[2];
            Assert.That(angle1, Is.EqualTo(correctAngle1).Within(0.01));
            Assert.That(angle2, Is.EqualTo(correctAngle2).Within(0.01));
            Assert.That(angle3, Is.EqualTo(correctAngle3).Within(0.01));
        }

        [Test]
        [TestCase(6, 6, 6)]
        [TestCase(7, 12, 6)]
        [TestCase(4, 4, 7)]
        [TestCase(13, 6, 9)]
        public void IsRectangularTriangle_NonRectangularValues_False(params double[] sides)
        {
            ITriangle triangle = new Triangle(sides);
            Assert.That(triangle.IsRectangular(), Is.Not.True);
        }

        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(8, 15, 17)]
        [TestCase(6, 8, 10)]
        [TestCase(7, 24, 25)]
        public void IsRectangularTriangle_RectangularValues_True(params double[] sides)
        {
            ITriangle triangle = new Triangle(sides);
            Assert.That(triangle.IsRectangular(), Is.True);
        }

        [Test]
        [TestCase(3, 4, 8)]
        [TestCase(1, 2, 3)]
        [TestCase(5, 5, 10)]
        [TestCase(-3, -4, -5)]
        public void CreatingTriangle_InorrectSideValues_IncorrectFigureParametersException(params double[] sides)
        {
            Assert.Throws<IncorrectFigureParametersException>(() => new Triangle(sides));
        }

        [Test]
        [TestCase(3, 4, 8, 2)]
        [TestCase(1, 2, 3, 4, 5, 6, 7, 8)]
        [TestCase(5, 5)]
        [TestCase(2)]
        [TestCase()]
        public void CreatingTriangle_InorrectSideCount_IncorrectFigureParametersException(params double[] sides)
        {
            Assert.Throws<IncorrectFigureParametersException>(() => new Triangle(sides));
        }
    }
}
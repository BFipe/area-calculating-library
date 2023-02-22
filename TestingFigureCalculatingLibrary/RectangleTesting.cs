using FigureCalculatingLibrary.Figures.Rectangular;
using FigureCalculatingLibrary.Interfaces.CommonShapeFunctions;
using SquareCalculating.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingFigureCalculatingLibrary
{
    [TestFixture]
    public class RectangleTesting
    {
        [Test]
        [TestCase(1 ,2)]
        [TestCase(5 ,2)]
        [TestCase(8 ,12)]
        [TestCase(18 ,20)]
        public void RectangleCreating_CorrectSides_SucsessfullCreating(params double[] sides) 
        {
            Rectangle rectangle= new Rectangle(sides);
            Assert.That(rectangle.Sides[0], Is.EqualTo(sides[0]));
            Assert.That(rectangle.Sides[1], Is.EqualTo(sides[1]));
            Assert.That(rectangle.Angles.All(q => q == 90), Is.True);
            Assert.That(rectangle.Name, Is.EqualTo("Rectangle"));
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(-5, 12)]
        [TestCase(0, 0)]
        [TestCase(-6, 7)]
        public void RectangleCreating_InorrectSideValuesCorrectCount_IncorrectFigureParametersException(params double[] sides)
        {
            Assert.Throws<IncorrectFigureParametersException>(() => new Rectangle(sides));
        }

        [Test]
        [TestCase(1, 10, 4)]
        [TestCase(5, 12, 56)]
        [TestCase(6, 8, 10, 17, 16, 15, 77)]
        [TestCase(2)]
        [TestCase()]
        public void RectangleCreating_IncorrectCount_IncorrectFigureParametersException(params double[] sides)
        {
            Assert.Throws<IncorrectFigureParametersException>(() => new Rectangle(sides));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(10, 5, 2)]
        [TestCase(60, 5, 12)]
        [TestCase(200, 10, 20)]
        public void CalculateArea_CorrectSides_CorrectAreaValue(double answer, params double[] sides)
        {
            IAreaCalculatable rectangle = new Rectangle(sides);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(answer));
        }
    }
}

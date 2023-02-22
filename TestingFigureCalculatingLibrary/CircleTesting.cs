using FigureCalculatingLibrary.Figures.Circular;
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
    public class CircleTesting
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(10)]
        public void CreatingCircle_CorrectValue_SucessfullCreating(double radius) 
        {
            Circle circle = new Circle(radius);
            Assert.That(circle.Name, Is.EqualTo("Circle"));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-56)]
        [TestCase(-3)]
        [TestCase(0)]
        public void CreatingCircle_ÌncorrectValue_SucessfullCreating(double radius)
        {
            Assert.Throws<IncorrectFigureParametersException>(() => new Circle(radius));
        }

        [Test]
        [TestCase(1, 3.14)]
        [TestCase(2, 12.57)]
        [TestCase(0.5, 0.79)]
        [TestCase(10, 314.16)]
        public void CircleAreaCalculating_CorrectValue_CorrectAreaValue(double radius, double answer)
        {
            IAreaCalculatable circle = new Circle(radius);
            Assert.That(circle.CalculateArea(), Is.EqualTo(answer).Within(0.01));
        }
    }
}

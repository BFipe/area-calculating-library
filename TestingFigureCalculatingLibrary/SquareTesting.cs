using FigureCalculatingLibrary.Figures.Rectangular;
using FigureCalculatingLibrary.Interfaces.CommonShapeFunctions;
using SquareCalculating.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingFigureCalculatingLibrary
{
    [TestFixture]
    public class SquareTesting
    {
        [Test]
        [TestCase(3)]
        [TestCase(13)]
        [TestCase(54)]
        [TestCase(23)]
        [TestCase(12)]
        public void SquareCreating_CorrectSideValue_SucesfullCreating(double side) 
        {
            Square square = new Square(side);
            Assert.That(square.Sides.All(q => q == side), Is.True);
            Assert.That(square.Name, Is.EqualTo("Square"));

        }

        [Test]
        [TestCase(-4)]
        [TestCase(-24)]
        [TestCase(0)]
        [TestCase(-1)]
        public void SquareCreating_IncorrectSideValue_IncorrectFigureParametersException(double side)
        {
            Assert.Throws<IncorrectFigureParametersException>(() => new Square(side));
        }

        //Необязательная часть, так как проверки сделаны в родителе, но лишние тесты не помешают нам
        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(5, 25)]
        [TestCase(10, 100)]
        public void AreaCalculating_CorrectSideValue_CorrectAreaValue(double side, double answer)
        {
            IAreaCalculatable square = new Square(side);
            Assert.That(square.CalculateArea(), Is.EqualTo(answer));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculating.Exceptions
{
    public class IncorrectFigureParametersException : Exception
    {
        public IncorrectFigureParametersException(string figureName) : base($"Incorrect parameters for figure {figureName}") { }
    }
}

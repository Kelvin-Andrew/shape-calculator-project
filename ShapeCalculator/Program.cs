using System;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCalculatorFacade shapeCalculatorFacade = new ShapeCalculatorFacade();
            shapeCalculatorFacade.RunMenu();
        }
    }
}

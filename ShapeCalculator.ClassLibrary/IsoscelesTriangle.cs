using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class IsoscelesTriangle: TwoDAttributes, IShape2D
    {
        public string ShapeName {get;} = "Isosceles Triangle";

        public SortedList<string, double> ShapeInputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"side", 0.0},
            {"base", 0.0},
            {"height", 0.0}
        };
        
        public double CalculateArea(SortedList<string, double> shapeattributes)
        {
            return (shapeattributes["base"] * shapeattributes["height"]) / 2;
        }

        public double CalculatePerimeter(SortedList<string, double> shapeattributes)
        {
            return 2.0 * shapeattributes["side"] + shapeattributes["base"];
        }
    }
}
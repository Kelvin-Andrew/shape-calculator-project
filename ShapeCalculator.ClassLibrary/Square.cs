using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class Square: TwoDAttributes, IShape2D
    {
        public string ShapeName {get;} = "Square";

        public SortedList<string, double> ShapeInputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"side length", 0.0}
        };
        
        public double CalculateArea(SortedList<string, double> shapeattributes)
        {
            return Math.Pow(shapeattributes["side length"], 2);
        }

        public double CalculatePerimeter(SortedList<string, double> shapeattributes)
        {
            return shapeattributes["side length"] * 4;
        }
    }
}
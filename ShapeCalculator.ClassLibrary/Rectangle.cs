using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class Rectangle: TwoDAttributes, IShape2D
    {
        public string ShapeName {get;} = "Rectangle";

        public SortedList<string, double> ShapeInputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"length", 0.0},
            {"width", 0.0}
        };
        
        public double CalculateArea(SortedList<string, double> shapeattributes)
        {
            return shapeattributes["length"] * shapeattributes["width"];
        }

        public double CalculatePerimeter(SortedList<string, double> shapeattributes)
        {
            return shapeattributes["length"] * 2 + shapeattributes["width"] * 2;
        }          
    }
}
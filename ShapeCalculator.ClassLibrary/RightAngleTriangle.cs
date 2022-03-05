using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class RightAngleTriangle: TwoDAttributes, IShape2D
    {
        public string ShapeName {get;} = "Right Angle Triangle";

        public SortedList<string, double> ShapeInputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"leg height", 0.0},
            {"leg base", 0.0}
        };
        
        public double CalculateArea(SortedList<string, double> shapeattributes)
        {
            return (shapeattributes["leg height"] * shapeattributes["leg base"]) / 2;
        }

        public double CalculatePerimeter(SortedList<string, double> shapeattributes)
        {
            return shapeattributes["leg height"] + shapeattributes["leg base"] + Math.Sqrt(Math.Pow(shapeattributes["leg height"], 2) + Math.Pow(shapeattributes["leg base"], 2));
        }
    }
}
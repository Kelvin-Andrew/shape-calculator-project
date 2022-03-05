using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class Circle
    {
        public string ShapeName {get;} = "Circle";

        public SortedList<string, double> ShapeInputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"radius", 0.0}
        };

        public SortedList<string, double> ShapeOutputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"area", 0.0},
            {"circumference", 0.0}
        };
        
        public double CalculateArea(SortedList<string, double> shapeattributes)
        {
            return Math.PI * Math.Pow(shapeattributes["radius"], 2);
        }

        public double CalculateCircumference(SortedList<string, double> shapeattributes)
        {
            return 2 * Math.PI * shapeattributes["radius"];
        }
    }
}
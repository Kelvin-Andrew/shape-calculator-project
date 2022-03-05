using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class Cube: ThreeDAttributes, IShape3D
    {
        public string ShapeName {get;} = "Cube";

        public SortedList<string, double> ShapeInputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"side length", 0.0}
        };
        
        public double CalculateSurfaceArea(SortedList<string, double> shapeattributes)
        {
            return Math.Pow(shapeattributes["side length"], 2) * 6;
        }

        public double CalculateVolume(SortedList<string, double> shapeattributes)
        {
            return Math.Pow(shapeattributes["side length"], 3);
        }
    }
}
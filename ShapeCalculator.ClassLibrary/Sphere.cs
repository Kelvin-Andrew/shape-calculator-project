using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class Sphere: ThreeDAttributes, IShape3D
    {
        public string ShapeName {get;} = "Sphere";

        public SortedList<string, double> ShapeInputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"radius", 0.0}
        };
        
        public double CalculateSurfaceArea(SortedList<string, double> shapeattributes)
        {
            return 4.0 * Math.PI * Math.Pow(shapeattributes["radius"], 2);
        }

        public double CalculateVolume(SortedList<string, double> shapeattributes)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(shapeattributes["radius"], 3);
        }
    }
}
using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class Cuboid: ThreeDAttributes, IShape3D
    {
        public string ShapeName {get;} = "Cuboid";

        public SortedList<string, double> ShapeInputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"length", 0.0},
            {"width", 0.0},
            {"height", 0.0}
        };
        
        public double CalculateSurfaceArea(SortedList<string, double> shapeattributes)
        {
            return 2 * (shapeattributes["length"] * shapeattributes["width"] + shapeattributes["length"] * shapeattributes["height"]
                        + shapeattributes["height"] * shapeattributes["width"]);
        }

        public double CalculateVolume(SortedList<string, double> shapeattributes)
        {
            return shapeattributes["length"] * shapeattributes["width"] * shapeattributes["height"];
        }
    }
}
using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class CircleAdapter: IShape2D
    {   
        Circle circle;
        public string ShapeName {get;}
        public SortedList<string, double> ShapeInputAttributes {get;set;} = new SortedList<string, double>();
        public SortedList<string, double> ShapeOutputAttributes {get;set;} = new SortedList<string, double>();
        public CircleAdapter(Circle circle)
        {
            this.circle = circle;
            this.ShapeName = circle.ShapeName;
            this.ShapeInputAttributes = circle.ShapeInputAttributes;
            this.ShapeOutputAttributes = circle.ShapeOutputAttributes;
        }

        public double CalculateArea(SortedList<string, double> shapeattributes)
        {
            return circle.CalculateArea(shapeattributes);
        }
    
        public double CalculatePerimeter(SortedList<string, double> shapeattributes)
        {
            return circle.CalculateCircumference(shapeattributes);
        }
    }
}
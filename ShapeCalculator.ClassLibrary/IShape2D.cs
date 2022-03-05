using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public interface IShape2D: IShape
    {   
        double CalculateArea(SortedList<string, double> ShapeAttributes);
        double CalculatePerimeter(SortedList<string, double> ShapeAttributes);
    }
}
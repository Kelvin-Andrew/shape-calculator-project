using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public interface IShape3D: IShape
    {   
        double CalculateSurfaceArea(SortedList<string, double> ShapeAttributes);
        double CalculateVolume(SortedList<string, double> ShapeAttributes);
    }
}
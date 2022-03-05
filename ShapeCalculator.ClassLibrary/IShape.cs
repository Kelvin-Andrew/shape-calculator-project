using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public interface IShape
    {   
        SortedList<string, double> ShapeOutputAttributes {get;set;}
        SortedList<string, double> ShapeInputAttributes {get;set;}
        string ShapeName {get;}
    }
}
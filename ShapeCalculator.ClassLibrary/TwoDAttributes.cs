using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public abstract class TwoDAttributes
    {
        public SortedList<string, double> ShapeOutputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"area", 0.0},
            {"perimeter", 0.0}
        };
    }
}
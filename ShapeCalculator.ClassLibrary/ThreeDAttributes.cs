using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public abstract class ThreeDAttributes
    {
        public SortedList<string, double> ShapeOutputAttributes {get;set;} = new SortedList<string, double>()
        {
            {"surface area", 0.0},
            {"volume", 0.0}
        };
    }
}
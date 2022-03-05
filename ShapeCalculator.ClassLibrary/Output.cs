using System;

namespace ShapeCalculator.ClassLibrary
{
    public class Output
    {
        public void OutputCalculation(string shapename, string attribute, double value)
        {
            Console.WriteLine($"{shapename}'s {attribute} is {Math.Round(value, 2)}");
        }
    }
}
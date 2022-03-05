using System;
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class Menu
    {
        public Pool pool;
        public InputValidation inputValidation;
        public int ShapeChoice {get;set;}

        public int DimensionChoice {get;set;}

        public Menu(Pool pool, InputValidation inputValidation)
        {
            this.pool = pool;
            this.inputValidation = inputValidation;
        }

        public void Request2DOr3DShapes()
        {
            Console.WriteLine("Please select from the following options: \nPress 1 to access 2D shapes\nPress 2 to access 3D shapes");
            DimensionChoice = inputValidation.ValidateDimensionMenuChoice(1, 2);  
        }

        public void Request2DShapeChoice()
        {
            int counter = 0;
            Console.WriteLine("Please select from the following options:");
            foreach(IShape2D shape in pool.ShapesPool2D)
            {
                Console.WriteLine($"Press {counter} to select {shape.ShapeName}");
                counter++;
            }
        }
        public void Request3DShapeChoice()
        {
            int counter = 0;
            Console.WriteLine("Please select from the following options:");
            foreach(IShape3D shape in pool.ShapesPool3D)
            {
                Console.WriteLine($"Press {counter} to select {shape.ShapeName}");
                counter++;
            }
        }
        public void SelectShape()
        {
            ShapeChoice = inputValidation.ValidateShapeMenuChoice(pool.ShapesPool2D.Count);  
        }

        public void RequestAttributeInput(string shapename, string attribute)
        {
            Console.WriteLine($"Please enter the {attribute} of the {shapename}");    
        } 
    }
}
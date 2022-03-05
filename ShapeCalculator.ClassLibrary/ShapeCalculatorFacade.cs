using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class ShapeCalculatorFacade
    {
        Pool pool;
        Menu menu;
        InputValidation inputValidation;
        Output output;
                
        public ShapeCalculatorFacade()
        {
            this.pool = new Pool();
            this.inputValidation = new InputValidation();
            this.menu = new Menu(this.pool, this.inputValidation);
            this.output = new Output();
        }

        private SortedList<string, double> CopySortedList(SortedList<string, double> original, SortedList<string, double> copy)
        {
            foreach(KeyValuePair<string, double> attribute in original)
            {
                copy.Add(attribute.Key, attribute.Value);
            }
            return copy;
        }

        public void RunMenu()
        {
            SortedList<string, double> copyShapeInputAttributes = new SortedList<string, double>();
            menu.Request2DOr3DShapes();
            if(menu.DimensionChoice == 1)
            {
                menu.Request2DShapeChoice();
                menu.SelectShape(); 
                List<IShape2D> activeShapePool = pool.ShapesPool2D;
                CopySortedList(pool.ShapesPool2D[menu.ShapeChoice].ShapeInputAttributes, copyShapeInputAttributes);
                foreach(KeyValuePair<string, double> attribute in copyShapeInputAttributes)
                {
                    menu.RequestAttributeInput(activeShapePool[menu.ShapeChoice].ShapeName, attribute.Key);
                    activeShapePool[menu.ShapeChoice].ShapeInputAttributes[attribute.Key] = inputValidation.ValidateDoubleInput();
                }
                activeShapePool[menu.ShapeChoice].ShapeOutputAttributes["area"] = activeShapePool[menu.ShapeChoice].CalculateArea(activeShapePool[menu.ShapeChoice].ShapeInputAttributes);
                if(activeShapePool[menu.ShapeChoice] is CircleAdapter)
                {
                    activeShapePool[menu.ShapeChoice].ShapeOutputAttributes["circumference"] = activeShapePool[menu.ShapeChoice].CalculatePerimeter(activeShapePool[menu.ShapeChoice].ShapeInputAttributes);
                }
                else
                {
                    activeShapePool[menu.ShapeChoice].ShapeOutputAttributes["perimeter"] = activeShapePool[menu.ShapeChoice].CalculatePerimeter(activeShapePool[menu.ShapeChoice].ShapeInputAttributes);
                }
                foreach(KeyValuePair<string, double> attribute in activeShapePool[menu.ShapeChoice].ShapeOutputAttributes)
                {
                    output.OutputCalculation(pool.ShapesPool2D[menu.ShapeChoice].ShapeName, 
                                            attribute.Key,
                                            attribute.Value);
                }  
            }
            else if(menu.DimensionChoice == 2)
            {
                menu.Request3DShapeChoice();
                menu.SelectShape(); 
                List<IShape3D> activeShapePool = pool.ShapesPool3D;
                CopySortedList(pool.ShapesPool3D[menu.ShapeChoice].ShapeInputAttributes, copyShapeInputAttributes);
                foreach(KeyValuePair<string, double> attribute in copyShapeInputAttributes)
                {
                    menu.RequestAttributeInput(activeShapePool[menu.ShapeChoice].ShapeName, attribute.Key);
                    activeShapePool[menu.ShapeChoice].ShapeInputAttributes[attribute.Key] = inputValidation.ValidateDoubleInput();
                } 
                activeShapePool[menu.ShapeChoice].ShapeOutputAttributes["surface area"] = activeShapePool[menu.ShapeChoice].CalculateSurfaceArea(activeShapePool[menu.ShapeChoice].ShapeInputAttributes);
                activeShapePool[menu.ShapeChoice].ShapeOutputAttributes["volume"] = activeShapePool[menu.ShapeChoice].CalculateVolume(activeShapePool[menu.ShapeChoice].ShapeInputAttributes);
                foreach(KeyValuePair<string, double> attribute in activeShapePool[menu.ShapeChoice].ShapeOutputAttributes)
                {      
                    output.OutputCalculation(pool.ShapesPool2D[menu.ShapeChoice].ShapeName, 
                                            attribute.Key,
                                            attribute.Value);
                }  
            }     
        }
    }
}
using System.Collections.Generic;

namespace ShapeCalculator.ClassLibrary
{
    public class Pool
    {
        public List<IShape2D> ShapesPool2D = new List<IShape2D>()
        {
            new Square(),
            new Rectangle(),
            new CircleAdapter(new Circle()), 
            new RightAngleTriangle(),
            new IsoscelesTriangle()
        };

        public List<IShape3D> ShapesPool3D = new List<IShape3D>()
        {
            new Cube(),
            new Cuboid(),
            new Sphere()
        }; 
    }
}
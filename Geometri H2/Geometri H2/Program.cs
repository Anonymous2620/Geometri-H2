using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {
                new Square(5),
                new Rectangle(3,5),
                new Parallelogram(3,5,20),
                new Trapez(10, 9, 8, 9),
                new Triangle(10, 6, 10)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Name  + "\n" +
                                  shape.CalculateArea() + "\n" +
                                  shape.CalculatePerimeter());
            }


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_H2
{
    class Square : Shape
    {
        double a;
        
        public Square(double a)
        {
            A = a;
            Name = "Square";
        }

        public double A { get => a; set => a = value; }

        public override double CalculatePerimeter()
        {
            return 4 * A;
        }

        public override double CalculateArea()
        {
            return A * A;
        }

    }
}

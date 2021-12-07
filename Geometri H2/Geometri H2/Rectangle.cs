using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_H2
{
    class Rectangle : Square
    {
        double b;

        public Rectangle(double a, double b) : base(a)
        {
            B = b;
            Name = "Rectangle";
        }
        
        public double B { get => b; set => b = value; }

        public override double CalculateArea()
        {
            return A * b;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (A + b);
        }
    }
}

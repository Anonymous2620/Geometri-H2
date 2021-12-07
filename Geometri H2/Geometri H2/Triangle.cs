    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_H2
{
    class Triangle : Shape
    {
        double a, b, c;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            Name = "Triangle";
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public override double CalculateArea()
        {
            return .5 * (A * B);
        }

        public override double CalculatePerimeter()
        {
            return A + B + C;
        }
    }
}

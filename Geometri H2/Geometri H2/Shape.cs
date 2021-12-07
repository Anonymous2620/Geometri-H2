using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_H2
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public string Name;
    }
}

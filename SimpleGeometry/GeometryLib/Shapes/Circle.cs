using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Debug.Assert(radius > 0, "radius > 0");
            Radius = radius;
        }
        public override string Print()
        {
            double area = 0;

            area = Area();
            return string.Format("Circle: radius = {0}, area = {1}", this.Radius, area);
        }
        public override double Area()
        {
            double area = 0;
            area = this.Radius * this.Radius * Math.PI;
            return area;
        }
    }
}

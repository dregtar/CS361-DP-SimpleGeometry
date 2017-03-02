using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Произвольный треугольник
    /// </summary>
    public class Triangle : Shape
    {
        // Длины сторон треугольника
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Debug.Assert(side1 > 0, "side1 > 0");
            Debug.Assert(side2 > 0, "side2 > 0");
            Debug.Assert(side3 > 0, "side3 > 0");
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override string Print()
        {
            double area = 0;

            area = Area();
            return string.Format("Triangle sides: {0}, {1}, {2}, area = {3}", this.Side1, this.Side2, this.Side3, area);
        }
        public override double Area()
        {
            double area = 0;
            var side1 = this.Side1;
            var side2 = this.Side2;
            var side3 = this.Side3;
            var p = (side1 + side2 + side3) / 2;
            area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

            return area;
        }
    }
}

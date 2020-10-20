using AbstractClassAndMethods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AbstractClassAndMethods.Entities.Shapes
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public double Pi { get; set; }

        public Circle(){ }
        public Circle(Color color, double radius) : base (color)
        {
            Radius = radius;
            Pi = Math.PI;
        }

        public override double Area()
        {
            return Radius * Pi;
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Circle Area - ");
            s.Append(Area().ToString("F2",CultureInfo.InvariantCulture));
            return s.ToString();
        }
    }
}

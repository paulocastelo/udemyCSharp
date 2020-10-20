using AbstractClassAndMethods.Entities.Enums;
using System.Globalization;
using System.Text;

namespace AbstractClassAndMethods.Entities.Shapes
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() { }
        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Rectangle Area - ");
            s.Append(Area().ToString("F2", CultureInfo.InvariantCulture));
            return s.ToString();
        }
    }
}

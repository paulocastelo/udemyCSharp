using System;
using Section14ContractInheritance.Model.Entities;
using Section14ContractInheritance.Model.Enums;

namespace Section14ContractInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            Shape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            IShape s3 = new CircleAbstract() { Radius = 2.0, Color = Color.White };
            IShape s4 = new RectangleAbstract() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}

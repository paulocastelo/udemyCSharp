using Section14ContractInheritance.Model.Enums;
namespace Section14ContractInheritance.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
using Section14ContractInheritance.Model.Entities;
using Section14ContractInheritance.Model.Enums;

namespace Section14ContractInheritance.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FixacaoListasUm
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; private set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void Increase(double percentage)
        {
            if (percentage > 0)
            {
                Salary += (Salary * percentage) / 100;
            }
        }

        public override string ToString()
        {
            return Id + ", " +
                Name + ", "+
                Salary + ".";
        }
    }
}

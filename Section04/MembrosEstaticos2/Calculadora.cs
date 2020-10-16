using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos2
{
    class Calculadora
    {
        public double Pi = 3.14;

        public double Circunferencia(double raio)
        {
            return 2.0 * raio * Pi;
        }

        public double Volume(double raio)
        {
            return (4.0 / 3.0) * Pi * (Math.Pow(raio, 3));
        }
    }
}

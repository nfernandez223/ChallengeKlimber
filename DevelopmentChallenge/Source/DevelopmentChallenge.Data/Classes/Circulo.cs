using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _lado;

        public Circulo(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        public override string Traducir(int idioma)
        {
            switch (idioma)
            {
                case Castellano:
                    return "Circulo";
                case Ingles:
                    return "Circle";
                case Italiano:
                    return "Cerchio";
                default:
                    throw new ArgumentException("Idioma no soportado");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica 
    {
        private readonly decimal _lado;

        public Trapecio(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((_lado+_lado)*_lado)/2;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public override string Traducir(int idioma)
        {
            switch (idioma)
            {
                case Castellano:
                    return "Trapecio";
                case Ingles:
                    return "Trapeze";
                case Italiano:
                    return "Trapezio";
                default:
                    throw new ArgumentException("Idioma no soportado");
            }
        }
    }
}

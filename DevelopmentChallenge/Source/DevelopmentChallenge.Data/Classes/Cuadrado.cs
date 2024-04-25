using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
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
                    return "Cuadrado";
                case Ingles:
                    return "Square";
                case Italiano:
                    return "Quadrato";
                default:
                    throw new ArgumentException("Idioma no soportado");
            }
        }
    }
}

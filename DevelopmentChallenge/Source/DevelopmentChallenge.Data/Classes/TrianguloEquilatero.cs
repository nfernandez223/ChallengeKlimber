using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return (_lado * _lado)/2;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public override string Traducir(int idioma)
        {
            switch (idioma)
            {
                case Castellano:
                    return "Triangulo Equilatero";
                case Ingles:
                    return "Equilateral Triangle";
                case Italiano:
                    return "Triangolo Equilatero";
                default:
                    throw new ArgumentException("Idioma no soportado");
            }
        }
    }
}

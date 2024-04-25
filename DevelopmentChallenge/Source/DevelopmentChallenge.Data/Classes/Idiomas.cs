using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Idiomas
    {
        public static string Traducir(string texto, int idioma)
        {
            switch (idioma)
            {
                case 1:
                    return TraducirCastellano(texto);
                case 2:
                    return TraducirIngles(texto);
                case 3:
                    return TraducirItaliano(texto);
                default:
                    throw new ArgumentException("Idioma no soportado");
            }
        }

        private static string TraducirCastellano(string texto)
        {
            switch (texto)
            {
                case "Lista vacía de formas!":
                    return "Lista vacía de formas!";
                case "Reporte de Formas":
                    return "Reporte de Formas";
                case "TOTAL":
                    return "TOTAL";
                case "forma":
                    return "forma";
                case "formas":
                    return "formas";
                case "Area":
                    return "Area";
                case "Perimetro":
                    return "Perimetro";
                default:
                    throw new ArgumentException("Texto no reconocido");
            }
        }

        private static string TraducirIngles(string texto)
        {
            switch (texto)
            {
                case "Lista vacía de formas!":
                    return "Empty list of shapes!";
                case "Reporte de Formas":
                    return "Shapes report";
                case "TOTAL":
                    return "TOTAL";
                case "forma":
                    return "shape";
                case "formas":
                    return "shapes";
                case "Area":
                    return "Area";
                case "Perimetro":
                    return "Perimeter";
                default:
                    throw new ArgumentException("Unrecognized text");
            }
        }

        private static string TraducirItaliano(string texto)
        {
            switch (texto)
            {
                case "Lista vacía de formas!":
                    return "Lista vuota di forme!";
                case "Reporte de Formas":
                    return "Report di forme";
                case "TOTAL":
                    return "TOTALE";
                case "forma":
                    return "forma";                
                case "formas":
                    return "forme";
                case "Area":
                    return "La Zona";
                case "Perimetro":
                    return "Perimetro";
                default:
                    throw new ArgumentException("Testo non riconosciuto");
            }
        }
    }
}

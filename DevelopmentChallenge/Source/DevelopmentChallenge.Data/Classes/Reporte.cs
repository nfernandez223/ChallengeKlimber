using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Reporte
    {
        public string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append("<h1>" + Idiomas.Traducir("Lista vacía de formas!", idioma) + "</h1>");
            }
            else
            {
                // HEADER
                sb.Append("<h1>" + Idiomas.Traducir("Reporte de Formas", idioma) + "</h1>");

                foreach (var forma in formas)
                {
                    sb.Append(forma.Traducir(idioma) + " | " + Idiomas.Traducir("Area", idioma) + " " + forma.CalcularArea().ToString("#.##") + " | " + Idiomas.Traducir("Perimetro", idioma) + " " + forma.CalcularPerimetro().ToString("#.##") + " |");
                }

                // FOOTER
                sb.Append("<p>" + Idiomas.Traducir("TOTAL", idioma) + ": " + formas.Count + " " + (formas.Count > 1 ? Idiomas.Traducir("formas", idioma) : Idiomas.Traducir("forma", idioma)) + "</p>");
            }

            return sb.ToString();
        }
    }
}

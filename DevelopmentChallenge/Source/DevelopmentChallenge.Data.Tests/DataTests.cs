using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    public abstract class DataTests
    {
        protected List<FormaGeometrica> Formas { get; set; }

        protected abstract int Idioma { get; }
        protected Reporte Reporte { get; set; }

        protected DataTests()
        {
            Formas = new List<FormaGeometrica>();
            Reporte = new Reporte();
        }

        [SetUp]
        public void Setup()
        {
            ConfigurarFormas();
        }

        protected abstract void ConfigurarFormas();
    }

    [TestFixture]
    public class DataTestsCastellano : DataTests
    {
        protected override int Idioma => FormaGeometrica.Castellano;

        protected override void ConfigurarFormas()
        {
          Formas.Add(new Cuadrado(5));         
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.That(Reporte.Imprimir(new List<FormaGeometrica>(), Idioma), Is.EqualTo("<h1>Lista vacía de formas!</h1>"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            Formas.Clear();
            Formas.Add(new Cuadrado(5));
            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Reporte de Formas</h1>Cuadrado | Area 25 | Perimetro 20 |<p>TOTAL: 1 forma</p>"));

        }        
        
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            Formas.Add(new Cuadrado(1));
            Formas.Add(new Cuadrado(3));

            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Reporte de Formas</h1>Cuadrado | Area 25 | Perimetro 20 |Cuadrado | Area 1 | Perimetro 4 |Cuadrado | Area 9 | Perimetro 12 |<p>TOTAL: 3 formas</p>"));

        }        
        
        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            Formas.Clear();
            Formas.Add(new Cuadrado(5));
            Formas.Add(new Circulo(3));
            Formas.Add(new TrianguloEquilatero(4));
            Formas.Add(new Cuadrado(2));
            Formas.Add(new TrianguloEquilatero(9));
            Formas.Add(new Circulo(2.73m));
            Formas.Add(new TrianguloEquilatero(4.2m));

            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Reporte de Formas</h1>Cuadrado | Area 25 | Perimetro 20 |Circulo | Area 7.07 | Perimetro 9.42 |Triangulo Equilatero | Area 8 | Perimetro 12 |Cuadrado | Area 4 | Perimetro 8 |Triangulo Equilatero | Area 40.5 | Perimetro 27 |Circulo | Area 5.85 | Perimetro 8.58 |Triangulo Equilatero | Area 8.82 | Perimetro 12.6 |<p>TOTAL: 7 formas</p>"));

        }

        [TestCase]
        public void TestResumenListaConTrapecioYReactangulo()
        {
            Formas.Clear();
            Formas.Add(new Trapecio(5));
            Formas.Add(new Rectangulo(4));

            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Reporte de Formas</h1>Trapecio | Area 25 | Perimetro 20 |Rectangulo | Area 16 | Perimetro 16 |<p>TOTAL: 2 formas</p>"));

        }

    }

    [TestFixture]
    public class DataTestsIngles : DataTests
    {
        protected override int Idioma => FormaGeometrica.Ingles;

        protected override void ConfigurarFormas()
        {
            Formas.Add(new Cuadrado(5));
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.That(Reporte.Imprimir(new List<FormaGeometrica>(), Idioma), Is.EqualTo("<h1>Empty list of shapes!</h1>"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            Formas.Clear();
            Formas.Add(new Cuadrado(5));
            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Shapes report</h1>Square | Area 25 | Perimeter 20 |<p>TOTAL: 1 shape</p>"));

        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            Formas.Add(new Cuadrado(1));
            Formas.Add(new Cuadrado(3));

            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Shapes report</h1>Square | Area 25 | Perimeter 20 |Square | Area 1 | Perimeter 4 |Square | Area 9 | Perimeter 12 |<p>TOTAL: 3 shapes</p>"));

        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            Formas.Clear();
            Formas.Add(new Cuadrado(5));
            Formas.Add(new Circulo(3));
            Formas.Add(new TrianguloEquilatero(4));
            Formas.Add(new Cuadrado(2));
            Formas.Add(new TrianguloEquilatero(9));
            Formas.Add(new Circulo(2.73m));
            Formas.Add(new TrianguloEquilatero(4.2m));

            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Shapes report</h1>Square | Area 25 | Perimeter 20 |Circle | Area 7.07 | Perimeter 9.42 |Equilateral Triangle | Area 8 | Perimeter 12 |Square | Area 4 | Perimeter 8 |Equilateral Triangle | Area 40.5 | Perimeter 27 |Circle | Area 5.85 | Perimeter 8.58 |Equilateral Triangle | Area 8.82 | Perimeter 12.6 |<p>TOTAL: 7 shapes</p>"));

        }

        [TestCase]
        public void TestResumenListaConTrapecioYReactangulo()
        {
            Formas.Clear();
            Formas.Add(new Trapecio(5));
            Formas.Add(new Rectangulo(4));

            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Shapes report</h1>Trapeze | Area 25 | Perimeter 20 |Rectangle | Area 16 | Perimeter 16 |<p>TOTAL: 2 shapes</p>"));

        }

    }

    [TestFixture]
    public class DataTestsITaliano : DataTests
    {
        protected override int Idioma => FormaGeometrica.Italiano;

        protected override void ConfigurarFormas()
        {
            Formas.Add(new Cuadrado(5));
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.That(Reporte.Imprimir(new List<FormaGeometrica>(), Idioma), Is.EqualTo("<h1>Lista vuota di forme!</h1>"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            Formas.Clear();
            Formas.Add(new Cuadrado(5));
            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Report di forme</h1>Quadrato | La Zona 25 | Perimetro 20 |<p>TOTALE: 1 forma</p>"));

        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            Formas.Add(new Cuadrado(1));
            Formas.Add(new Cuadrado(3));

            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Report di forme</h1>Quadrato | La Zona 25 | Perimetro 20 |Quadrato | La Zona 1 | Perimetro 4 |Quadrato | La Zona 9 | Perimetro 12 |<p>TOTALE: 3 forme</p>"));

        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            Formas.Clear();
            Formas.Add(new Cuadrado(5));
            Formas.Add(new Circulo(3));
            Formas.Add(new TrianguloEquilatero(4));
            Formas.Add(new Cuadrado(2));
            Formas.Add(new TrianguloEquilatero(9));
            Formas.Add(new Circulo(2.73m));
            Formas.Add(new TrianguloEquilatero(4.2m));

            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Report di forme</h1>Quadrato | La Zona 25 | Perimetro 20 |Cerchio | La Zona 7.07 | Perimetro 9.42 |Triangolo Equilatero | La Zona 8 | Perimetro 12 |Quadrato | La Zona 4 | Perimetro 8 |Triangolo Equilatero | La Zona 40.5 | Perimetro 27 |Cerchio | La Zona 5.85 | Perimetro 8.58 |Triangolo Equilatero | La Zona 8.82 | Perimetro 12.6 |<p>TOTALE: 7 forme</p>"));

        }

        [TestCase]
        public void TestResumenListaConTrapecioYReactangulo()
        {
            Formas.Clear();
            Formas.Add(new Trapecio(5));
            Formas.Add(new Rectangulo(4));

            var resumen = Reporte.Imprimir(Formas, Idioma);
            Assert.That(resumen, Is.EqualTo("<h1>Report di forme</h1>Trapezio | La Zona 25 | Perimetro 20 |Rerrangolo | La Zona 16 | Perimetro 16 |<p>TOTALE: 2 forme</p>"));

        }

    }
    
}

using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;
using CodingChallenge.Data.Idiomas;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Resumen.Imprimir(new List<FiguraGeometrica>(), new Espaniol()));
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Resumen.Imprimir(new List<FiguraGeometrica>(), new Ingles()));
            Assert.AreEqual("<h1>Liste vide de formes!</h1>",
                Resumen.Imprimir(new List<FiguraGeometrica>(), new Frances()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FiguraGeometrica> { new Cuadrado(5) };

            var resumen = Resumen.Imprimir(cuadrados, new Espaniol());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FiguraGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Resumen.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FiguraGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumenIngles = Resumen.Imprimir(formas, new Ingles());
            var resumenEspaiol = Resumen.Imprimir(formas, new Espaniol());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumenIngles);
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumenEspaiol);
        }

        [TestCase]
        public void TestResumenListaConNuevosTipos()
        {
            var formas = new List<FiguraGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new TrapecioRectangulo(5, 3, 2),
                new Cuadrado(2),
                new Rectangulo(7, 3),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrapecioRectangulo(9, 2.4m, 4.1m),
                new TrianguloEquilatero(4.2m)
            };

            var resumenEspaniol = Resumen.Imprimir(formas, new Espaniol());
            var resumenFrances = Resumen.Imprimir(formas, new Frances());
            var resumenIngles = Resumen.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>2 Trapecios | Area 31,37 | Perimetro 36,1 <br/>1 Rectángulo | Area 21 | Perimetro 20 <br/>TOTAL:<br/>10 formas Perimetro 153,76 Area 144,02",
                resumenEspaniol);
            Assert.AreEqual(
                "<h1>Rapport de Formes</h1>2 Carrés | Surface 29 | Périmètre 28 <br/>2 Cercles | Surface 13,01 | Périmètre 18,06 <br/>3 Triangles | Surface 49,64 | Périmètre 51,6 <br/>2 Trapèzes | Surface 31,37 | Périmètre 36,1 <br/>1 Rectangle | Surface 21 | Périmètre 20 <br/>TOTAL:<br/>10 formes Périmètre 153,76 Surface 144,02",
                resumenFrances);
            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Trapezoids | Area 31,37 | Perimeter 36,1 <br/>1 Rectangle | Area 21 | Perimeter 20 <br/>TOTAL:<br/>10 shapes Perimeter 153,76 Area 144,02",
                resumenIngles);
        }
    }
}

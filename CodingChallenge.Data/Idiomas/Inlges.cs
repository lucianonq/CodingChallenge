using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Idiomas
{
    public class Ingles : Idioma
    {
        public Ingles()
        {
            ListaVacia = "Empty list of shapes!";
            Reporte = "Shapes report";
            Total = "TOTAL";
            Perimetro = "Perimeter";
            Area = "Area";
            Formas = "shapes";
            TraduccionFiguras = new Dictionary<string, string>() {
            { "Cuadrado", "Square"},
            { "TrapecioRectanulo", "Trapezium"},
            { "TrianguloEquilatero", "Triangle"},
            { "Circulo", "Circle"},
            { "Rectangulo", "Rectangle"},
            { "Cuadrados", "Squares"},
            { "TrapecioRectanulos", "Trapezoids"},
            { "TrianguloEquilateros", "Triangles"},
            { "Circulos", "Circles"},
            { "Rectangulos", "Rectangles"}
        };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Idiomas
{
    public class Espaniol : Idioma
    {
        public Espaniol()
        {
            ListaVacia = "Lista vacía de formas!";
            Total = "TOTAL";
            Perimetro = "Perimetro";
            Reporte = "Reporte de Formas";
            Area = "Area";
            Formas = "formas";
            TraduccionFiguras = new Dictionary<string, string>()
            {
                { "Cuadrado", "Cuadrado"},
                { "TrapecioRectanulo", "Trapecio"},
                { "TrianguloEquilatero", "Triangulo"},
                { "Circulo", "Circulo"},
                { "Rectangulo", "Rectángulo"},
                { "Cuadrados", "Cuadrados"},
                { "TrapecioRectanulos", "Trapecios"},
                { "TrianguloEquilateros", "Triángulos"},
                { "Circulos", "Círculos"},
                { "Rectangulos", "Rectángulos"}
            };
        }

    }
}

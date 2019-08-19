using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Idiomas
{
    public class Frances : Idioma
    {
        public Frances()
        {
            ListaVacia = "Liste vide de formes!";
            Total = "TOTAL";
            Perimetro = "Périmètre";
            Reporte = "Rapport de Formes";
            Area = "Surface";
            Formas = "formes";
            TraduccionFiguras = new Dictionary<string, string>()
            {
                { "Cuadrado", "Carré"},
                { "TrapecioRectanulo", "Trapèze"},
                { "TrianguloEquilatero", "Triangle"},
                { "Circulo", "Cercle"},
                { "Rectangulo", "Rectangle"},
                { "Cuadrados", "Carrés"},
                { "TrapecioRectanulos", "Trapèzes"},
                { "TrianguloEquilateros", "Triangles"},
                { "Circulos", "Cercles"},
                { "Rectangulos", "Rectangles"}
            };
        }
    }
}

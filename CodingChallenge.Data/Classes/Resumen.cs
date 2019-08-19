/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CodingChallenge.Data.Classes
{
    public sealed class Resumen
    {
        private Resumen() { }

        private static string TraducirForma(string figura, int cantidad, Idioma idioma)
        {
            return cantidad == 1 ? idioma.TraduccionFiguras[figura] : idioma.TraduccionFiguras[figura + "s"];
        }

        private static string ObtenerLinea(Resultado resultado, Idioma idioma)
        {
            var cantidad = resultado.Cantidad;

            if (cantidad > 0)
                return $"{cantidad} {TraducirForma(resultado.Figura, cantidad, idioma)} | {idioma.Area} {resultado.AreaTotal:#.##} | {idioma.Perimetro} {resultado.PerimetroTotal:#.##} <br/>";

            return string.Empty;
        }

        private static string Totales(Dictionary<string, Resultado> resultadoDeFiguras, Idioma idioma, List<FiguraGeometrica> formas)
        {
            StringBuilder sb = new StringBuilder();
            decimal perimetroTotal = 0;
            decimal areaTotal = 0;

            foreach (var figura in resultadoDeFiguras.Values)
            {
                sb.Append(ObtenerLinea(figura, idioma));
                perimetroTotal += figura.PerimetroTotal;
                areaTotal += figura.AreaTotal;
            }

            sb.Append(idioma.Total).Append(":<br/>");
            sb.Append(formas.Count).Append(" ").Append(idioma.Formas).Append(" ");
            sb.Append(idioma.Perimetro).Append(" ").Append((perimetroTotal).ToString("#.##")).Append(" ");
            sb.Append(idioma.Area).Append(" ").Append((areaTotal).ToString("#.##"));

            return sb.ToString();
        }

        private static void CalcularResultados(List<FiguraGeometrica> formas, Dictionary<string, Resultado> resultadoDeFiguras)
        {
            foreach (FiguraGeometrica forma in formas)
            {
                var resultado = resultadoDeFiguras[forma.GetType().Name];
                resultado.Cantidad++;
                resultado.AreaTotal += forma.ObtenerArea();
                resultado.PerimetroTotal += forma.ObtenerPerimetro();
            }
        }
        
        private static Dictionary<string, Resultado> DiccionarioDeResultados()
        {
            var diccionario = new Dictionary<string, Resultado>()
            {
                { "Cuadrado", new Resultado("Cuadrado")},
                { "Circulo", new Resultado("Circulo")},
                { "TrianguloEquilatero", new Resultado("TrianguloEquilatero")},
                { "TrapecioRectangulo", new Resultado("TrapecioRectanulo")},
                { "Rectangulo", new Resultado("Rectangulo")},
            };

            return diccionario;
        }

        public static string Imprimir(List<FiguraGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
                sb.Append("<h1>").Append(idioma.ListaVacia).Append("</h1>");
            else
            {
                var resultadoDeFiguras = DiccionarioDeResultados();
                sb.Append("<h1>").Append(idioma.Reporte).Append("</h1>");
                CalcularResultados(formas, resultadoDeFiguras);
                sb.Append(Totales(resultadoDeFiguras, idioma, formas));
            }

            return sb.ToString();
        }
    }
}

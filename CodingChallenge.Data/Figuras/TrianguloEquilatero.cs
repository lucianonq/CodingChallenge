using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FiguraGeometrica
    {
        public TrianguloEquilatero(decimal lado) : base(lado)
        {
            Lado = lado;
        }

        public override decimal ObtenerArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public override decimal ObtenerPerimetro()
        {
            return Lado * 3;
        }
    }
}
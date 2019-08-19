using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FiguraGeometrica
    {
        public Cuadrado(decimal lado) : base(lado)
        {
            Lado = lado;
        }

        public override decimal ObtenerArea()
        {
            return Lado * Lado;
        }

        public override decimal ObtenerPerimetro()
        {
            return Lado * 4;
        }
    }
}

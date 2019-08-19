using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FiguraGeometrica
    {
        public Circulo(decimal diametro) : base(diametro)
        {
            Lado = diametro;
        }

        public override decimal ObtenerArea()
        {
            return (decimal)Math.PI * (Lado / 2) * (Lado / 2);
        }

        public override decimal ObtenerPerimetro()
        {
            return (decimal)Math.PI * Lado;
        }
    }
}

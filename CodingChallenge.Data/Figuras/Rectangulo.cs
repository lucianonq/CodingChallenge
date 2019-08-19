using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FiguraGeometrica
    {
        public decimal Altura { get; set; }

        public Rectangulo(decimal ladoBaseMayor, decimal altura) : base(ladoBaseMayor)
        {
            Lado = ladoBaseMayor;
            Altura = altura;
        }

        public override decimal ObtenerArea()
        {
            return Lado * Altura;
        }

        public override decimal ObtenerPerimetro()
        {
            return Lado * 2 + Altura * 2;
        }
    }
}
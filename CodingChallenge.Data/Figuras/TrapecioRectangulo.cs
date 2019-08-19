using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrapecioRectangulo : FiguraGeometrica
    {
        public decimal Altura { get; set; }
        public decimal LadoMenor { get; set; }

        public TrapecioRectangulo(decimal ladoMayor, decimal ladoMenor, decimal altura) : base(ladoMayor)
        {
            Lado = ladoMayor;
            LadoMenor = ladoMenor;
            Altura = altura;
        }

        public override decimal ObtenerArea()
        {
            return (Lado + LadoMenor) * Altura / 2;
        }

        private decimal ObtenerHipotenusa()
        {
            return (decimal)Math.Sqrt((double)(Altura * Altura + (Lado - LadoMenor) * (Lado - LadoMenor)));
        }

        public override decimal ObtenerPerimetro()
        {
            return Altura + Lado + LadoMenor + ObtenerHipotenusa();
        }
    }
}

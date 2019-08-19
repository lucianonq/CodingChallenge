using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class FiguraGeometrica
    {
        public decimal Lado { get; set; }

        public FiguraGeometrica(decimal lado)
        {
            this.Lado = lado;
        }

        public abstract decimal ObtenerArea();

        public abstract decimal ObtenerPerimetro();
    }
}

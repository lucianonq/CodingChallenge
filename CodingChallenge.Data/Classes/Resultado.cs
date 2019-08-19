using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    class Resultado
    {
        public int Cantidad { get; set; }
        public decimal AreaTotal { get; set; }
        public decimal PerimetroTotal { get; set; }
        public string Figura { get; set; }

        public Resultado(string figura)
        {
            Figura = figura;
            Cantidad = 0;
            AreaTotal = 0m;
            PerimetroTotal = 0m;
        }
    }
}

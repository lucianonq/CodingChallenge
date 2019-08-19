using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Idiomas
{
    public abstract class Idioma
    {
        public Dictionary<string, string> TraduccionFiguras { get; set; }
        public string ListaVacia { get; set; }
        public string Reporte { get; set; }
        public string Total { get; set; }
        public string Formas { get; set; }
        public string Perimetro { get; set; }
        public string Area { get; set; }
    }
}

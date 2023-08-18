using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovicunCaribe.Modelos
{
    public class Coordenadas
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }

        public Coordenadas(double lt, double lg)
        {
            Latitud = lt;
            Longitud = lg;
        }
    }
}

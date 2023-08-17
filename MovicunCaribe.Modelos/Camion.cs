using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovicunCaribe.Modelos
{
    public class Camion
    {
        public int Id { get; set; }
        public string Ruta { get; set; }
        public Recorrido Tramo { get; set; }
        public Coordenadas Coord { get; set; }
    }
}

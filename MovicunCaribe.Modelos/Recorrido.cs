using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovicunCaribe.Modelos
{
    public class Recorrido
    {
        public int Id { get; set; }
        public Parada Inicio => Tramo?.FirstOrDefault();
        public Parada Fin => Tramo?.FirstOrDefault();
        public List<Parada> Tramo { get; set; }
    }
}

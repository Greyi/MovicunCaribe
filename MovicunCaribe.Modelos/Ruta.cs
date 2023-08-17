using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovicunCaribe.Modelos
{
    public class Ruta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Recorrido tramo { get; set; }
    }
}

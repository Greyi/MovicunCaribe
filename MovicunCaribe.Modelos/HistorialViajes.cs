using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovicunCaribe.Modelos
{
    public class HistorialViajes
    {
        public int Id { get; set; }
        public Camion Vehiculo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}

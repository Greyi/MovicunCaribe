using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovicunCaribe.Modelos
{
    public class PeticionParada
    {
        public int Id { get; set; }
        public Ruta RutaDeseada { get; set; }
        public List<Ruta> RutasAlternativas { get; set; }
        public Parada SitioSolicitado { get; set; }
        public DateTime Fecha { get; set; }
    }
}

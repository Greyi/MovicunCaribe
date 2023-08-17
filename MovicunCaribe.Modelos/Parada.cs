using System.Collections.Generic;

namespace MovicunCaribe.Modelos
{
    public class Parada
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Referencia { get; set; }
        public Coordenadas Coordenadas { get; set; }
        public List<FrecuenciaUso> Usos { get; set; }
    }
}
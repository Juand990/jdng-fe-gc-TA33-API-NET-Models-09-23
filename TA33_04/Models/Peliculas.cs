using System.Collections.Generic;

namespace TA33_04.Models
{
    public class Peliculas
    {
        public Peliculas()
        {
            Salas = new HashSet<Salas>();
        }
        public int Codigo { get; set; }
        public string Nombre { get; set;}
        public int CalificacionEdad { get; set; }

        public virtual ICollection<Salas> Salas { get; set; }
    }
}

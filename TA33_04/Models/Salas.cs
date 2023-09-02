using System.Collections.Generic;

namespace TA33_04.Models
{
    public class Salas
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int PeliculaCodigo { get; set; }

        public virtual Peliculas Peliculas { get; set; }

    }
}

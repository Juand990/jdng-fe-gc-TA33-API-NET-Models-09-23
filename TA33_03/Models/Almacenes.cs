using System.Collections.Generic;

namespace TA33_03.Models
{
    public class Almacenes
    {
        public Almacenes()
        {
            Cajas = new HashSet<Cajas>();
        }
        public int Codigo { get; set; }
        public string Lugar { get; set; }
        public int Capacidad { get; set; }

        public virtual ICollection<Cajas> Cajas { get; set; }
    }
}

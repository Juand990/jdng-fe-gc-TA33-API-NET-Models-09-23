using System.Collections.Generic;

namespace TA33_02.Models
{
    public class Departamentos
    {
        public Departamentos()
        {
            Empleados = new HashSet<Empleados>();
        }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Presupuesto { get; set; }

        public virtual ICollection<Empleados> Empleados { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TA33_01.Models
{
    public class Fabricantes
    {
        public Fabricantes()
        {
            Articulos= new HashSet<Articulos>();
        }
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Articulos> Articulos { get; }

    }
}

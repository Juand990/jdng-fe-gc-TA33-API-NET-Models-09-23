using Microsoft.EntityFrameworkCore;

namespace TA33_01.Models
{
    public partial class Articulos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int FabricanteCodigo { get; set; }
        public virtual Fabricantes Fabricantes { get; set; }
    }
}

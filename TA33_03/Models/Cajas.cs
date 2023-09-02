namespace TA33_03.Models
{
    public class Cajas
    {
        public string NumReferencia { get; set; }
        public string Contenido { get; set; }
        public int Valor { get; set; }
        public int AlmacenCodigo { get; set;}

        public virtual Almacenes Almacenes { get; set; }

    }
}

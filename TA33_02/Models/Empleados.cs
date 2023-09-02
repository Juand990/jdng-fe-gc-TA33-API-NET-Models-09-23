namespace TA33_02.Models
{
    public class Empleados
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int DepartamentoCodigo { get; set; }

        public virtual Departamentos Departamentos { get; set; }

    }
}

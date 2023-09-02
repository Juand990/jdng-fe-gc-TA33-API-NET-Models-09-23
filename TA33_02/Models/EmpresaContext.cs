using Microsoft.EntityFrameworkCore;

namespace TA33_02.Models
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> options)
        : base(options)
        {
        }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.ToTable("Departamentos");

                entity.HasKey(d => new { d.Codigo })
                .HasName("PrimaryKey_Codigo");

                entity.Property(d => d.Codigo).HasColumnName("Codigo");

                entity.Property(d => d.Nombre)
                .HasColumnName("Nombre")
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.Property(d => d.Presupuesto)
                .HasColumnName("Presupuesto");

            });
            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.ToTable("Empleados");

                entity.HasKey(e => new { e.DNI })
                .HasName("PrimaryKey_DNI");

                entity.Property(e => e.DNI).HasColumnName("DNI");

                entity.Property(e => e.Nombre)
                .HasColumnName("Nombre")
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                .HasColumnName("Apellidos")
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.HasOne(d => d.Departamentos)
                .WithMany(e => e.Empleados)
                .HasForeignKey(e => e.DepartamentoCodigo)
                .HasConstraintName("empleados_fk");

            });
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace TA33_03.Models
{
    public class AlmCajContext : DbContext
    {
        public AlmCajContext(DbContextOptions<AlmCajContext> options)
        : base(options)
        {
        }
        public virtual DbSet<Almacenes> Almacenes { get; set; }

        public virtual DbSet<Cajas> Cajas { get; set; }
                
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacenes>(entity =>
            {
                entity.ToTable("Almacenes");

                entity.HasKey(a => new { a.Codigo })
                .HasName("PrimaryKey_Codigo");

                entity.Property(a => a.Codigo).HasColumnName("Codigo");

                entity.Property(a => a.Lugar)
                .HasColumnName("Lugar")
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.Property(a => a.Capacidad)
                .HasColumnName("Capacidad")
                .HasColumnType("integer");
            });
            modelBuilder.Entity<Cajas>(entity =>
            {
                entity.ToTable("Cajas");

                entity.HasKey(c => new { c.NumReferencia })
                .HasName("PrimaryKey_NumReferencia");

                entity.Property(c => c.NumReferencia).HasColumnName("NumReferencia");

                entity.Property(c => c.AlmacenCodigo).HasColumnName("AlmacenCodigo");

                entity.Property(c => c.Contenido)
                .HasColumnName("Contenido")
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.Property(c => c.Valor)
                .HasColumnName("Valor")
                .HasColumnType("integer");

                entity.HasOne(c => c.Almacenes)
                .WithMany(a => a.Cajas)
                .HasForeignKey(c => c.AlmacenCodigo)
                .HasConstraintName("almacenes_fk");
            });
        }
    }
}

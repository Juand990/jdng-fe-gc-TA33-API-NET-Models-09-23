using Microsoft.EntityFrameworkCore;


namespace TA33_04.Models
{
    public class PelSalContext : DbContext
    {
        public PelSalContext(DbContextOptions<PelSalContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Peliculas> Peliculas { get; set; }

        public virtual DbSet<Salas> Salas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Peliculas>(entity =>
            {
                entity.ToTable("Peliculas");

                entity.HasKey(p => p.Codigo)
                .HasName("PrimaryKey_Codigo");

                entity.Property(p=>p.Codigo)
                .HasColumnName("Codigo");                
                
                entity.Property(p => p.Nombre)
                .HasColumnName("Nombre")
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.Property(p => p.CalificacionEdad)
                .HasColumnName("Nombre")
                .HasColumnName("integer");
            });
            modelBuilder.Entity<Salas>(entity =>
            {
                entity.ToTable("Salas");

                entity.HasKey(s => s.Codigo)
                .HasName("PrimaryKey_Codigo");

                entity.Property(s => s.PeliculaCodigo)
                .HasColumnName("PeliculaCodigo");

                entity.Property(s => s.Nombre)
                .HasColumnName("Nombre")
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.HasOne(s => s.Peliculas)
                .WithMany(p => p.Salas)
                .HasForeignKey(s => s.PeliculaCodigo)
                .HasConstraintName("peliculas_fk");
            });
        }
    }
}

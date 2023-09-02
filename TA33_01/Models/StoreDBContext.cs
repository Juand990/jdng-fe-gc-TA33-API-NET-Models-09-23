using Microsoft.EntityFrameworkCore;

namespace TA33_01.Models
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options)
        : base(options)
        {
        }
        public virtual DbSet<Fabricantes> Fabricantes { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Fabricantes>(entity =>
            {
                entity.ToTable("Fabricantes");

                entity.HasKey(f => new { f.Codigo })
                .HasName("PrimaryKey_Codigo");
                
                entity.Property(f => f.Codigo).HasColumnName("Codigo");

                entity.Property(f => f.Nombre)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Articulos>(entity =>
            {
                entity.ToTable("Articulos");

                entity.HasKey(a => a.Codigo)
                .HasName("PrimaryKey_Codigo");                               

                entity.Property(a => a.Codigo).HasColumnName("Codigo");

                entity.Property(a => a.Nombre).HasColumnName("Nombre");

                entity.Property(a => a.Precio).HasColumnType("decimal(10,2)");

                entity.Property(a => a.FabricanteCodigo).HasColumnName("FabricanteCodigo");

                entity.HasOne(f => f.Fabricantes)
                .WithMany(a => a.Articulos)
                .HasForeignKey(a => a.FabricanteCodigo)
                .IsRequired();
            });
        }
    }
}

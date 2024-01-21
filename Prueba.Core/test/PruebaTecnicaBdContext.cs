using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Prueba.Core.test
{
    public partial class PruebaTecnicaBdContext : DbContext
    {
        public PruebaTecnicaBdContext()
        {
        }

        public PruebaTecnicaBdContext(DbContextOptions<PruebaTecnicaBdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HabitacionHotel> HabitacionHotel { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<HabitacionHotel>(entity =>
            {
                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

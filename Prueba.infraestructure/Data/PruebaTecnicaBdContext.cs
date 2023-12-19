using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Prueba.Core.Entities;

#nullable disable

namespace Prueba.infraestructure.Data
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
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<HuespedesReserva> HuespedesReserva { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<ReservaHabitacion> ReservaHabitacion { get; set; }
        public virtual DbSet<ObtenerReservas> ObtenerReservas { get; set; }            

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

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.HabitacionHotel)
                    .HasForeignKey(d => d.HotelId)
                    .HasConstraintName("FK_HabitacionHotel_Hotel");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HuespedesReserva>(entity =>
            {
                entity.Property(e => e.Correo)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.NoDocumento)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.Reserva)
                    .WithMany(p => p.HuespedesReserva)
                    .HasForeignKey(d => d.ReservaId)
                    .HasConstraintName("FK_HuespedesReserva_Reserva");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.Property(e => e.Ciudad)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.NombreEmergencia)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoEmergencia)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReservaHabitacion>(entity =>
            {
                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.HasOne(d => d.Habitacion)
                    .WithMany(p => p.ReservaHabitacion)
                    .HasForeignKey(d => d.HabitacionId)
                    .HasConstraintName("FK_ReservaHabitacion_HabitacionHotel");

                entity.HasOne(d => d.Reserva)
                    .WithMany(p => p.ReservaHabitacion)
                    .HasForeignKey(d => d.ReservaId)
                    .HasConstraintName("FK_ReservaHabitacion_Reserva");
            });

            modelBuilder.Entity<ObtenerReservas>(entity =>
            {

                entity.Property(e => e.HotelNombre)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.NombreEmergencia)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoEmergencia)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });
            

        OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

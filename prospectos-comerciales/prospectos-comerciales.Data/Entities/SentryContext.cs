using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace prospectos_comerciales.Data.Entities
{
    public partial class SentryContext : DbContext
    {
        public SentryContext()
        {
        }

        public SentryContext(DbContextOptions<SentryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Prospecto> Prospecto { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prospecto>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentarios)
                    .HasColumnName("comentarios")
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasColumnName("empresa")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.IdColor).HasColumnName("idColor");

                entity.Property(e => e.IdContacto).HasColumnName("idContacto");

                entity.Property(e => e.IdSector).HasColumnName("idSector");

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("paginaWeb")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recepcionista)
                    .HasColumnName("recepcionista")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoRecepcion)
                    .IsRequired()
                    .HasColumnName("telefonoRecepcion")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Prospecto)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prospecto_Ciudad");

                entity.HasOne(d => d.IdColorNavigation)
                    .WithMany(p => p.Prospecto)
                    .HasForeignKey(d => d.IdColor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prospecto_Color");

                entity.HasOne(d => d.IdContactoNavigation)
                    .WithMany(p => p.Prospecto)
                    .HasForeignKey(d => d.IdContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prospecto_Contacto");

                entity.HasOne(d => d.IdSectorNavigation)
                    .WithMany(p => p.Prospecto)
                    .HasForeignKey(d => d.IdSector)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prospecto_Sector");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}

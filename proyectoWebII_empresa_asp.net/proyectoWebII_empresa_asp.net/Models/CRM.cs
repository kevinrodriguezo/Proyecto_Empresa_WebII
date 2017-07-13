namespace proyectoWebII_empresa_asp.net.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CRM : DbContext
    {
        public CRM()
            : base("name=CRM")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Reunion> Reunion { get; set; }
        public virtual DbSet<Soporte> Soporte { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.sector)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.pagina)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Reunion)
                .WithOptional(e => e.Cliente)
                .HasForeignKey(e => e.id_cliente);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Contacto)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.puesto)
                .IsUnicode(false);

            modelBuilder.Entity<Reunion>()
                .Property(e => e.titulo_reunion)
                .IsFixedLength();

            modelBuilder.Entity<Reunion>()
                .Property(e => e.fecha)
                .IsFixedLength();

            modelBuilder.Entity<Soporte>()
                .Property(e => e.Titulo_problema)
                .IsFixedLength();

            modelBuilder.Entity<Soporte>()
                .Property(e => e.Detalle_problema)
                .IsFixedLength();

            modelBuilder.Entity<Soporte>()
                .Property(e => e.resp_reportar_probl)
                .IsFixedLength();

            modelBuilder.Entity<Soporte>()
                .Property(e => e.estado_actual)
                .IsFixedLength();

            modelBuilder.Entity<usuario>()
                .Property(e => e.nombre)
                .IsFixedLength();

            modelBuilder.Entity<usuario>()
                .Property(e => e.apellido)
                .IsFixedLength();

            modelBuilder.Entity<usuario>()
                .Property(e => e.usuario1)
                .IsFixedLength();

            modelBuilder.Entity<usuario>()
                .Property(e => e.contrasena)
                .IsFixedLength();

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.Reunion)
                .WithOptional(e => e.usuario)
                .HasForeignKey(e => e.id_usuario);
        }
    }
}

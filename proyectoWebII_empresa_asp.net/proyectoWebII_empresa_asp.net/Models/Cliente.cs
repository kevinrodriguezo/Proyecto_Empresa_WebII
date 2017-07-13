namespace proyectoWebII_empresa_asp.net.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Reunion = new HashSet<Reunion>();
            Contacto = new HashSet<Contacto>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string nombre { get; set; }

        public int cedula { get; set; }

        [Required]
        [StringLength(20)]
        public string direccion { get; set; }

        [Required]
        [StringLength(20)]
        public string sector { get; set; }

        [Required]
        [StringLength(20)]
        public string pagina { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reunion> Reunion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contacto> Contacto { get; set; }
    }
}

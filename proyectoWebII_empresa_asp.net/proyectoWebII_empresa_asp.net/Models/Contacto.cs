namespace proyectoWebII_empresa_asp.net.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contacto")]
    public partial class Contacto
    {
        public int id { get; set; }

        public int id_cliente { get; set; }

        [Required]
        [StringLength(20)]
        public string nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string email { get; set; }

        [Required]
        [StringLength(30)]
        public string puesto { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}

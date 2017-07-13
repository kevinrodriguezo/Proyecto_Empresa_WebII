namespace proyectoWebII_empresa_asp.net.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reunion")]
    public partial class Reunion
    {
        public int id { get; set; }

        [StringLength(20)]
        public string titulo_reunion { get; set; }

        [StringLength(20)]
        public string fecha { get; set; }

        public int? id_usuario { get; set; }

        public int? id_cliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual usuario usuario { get; set; }
    }
}

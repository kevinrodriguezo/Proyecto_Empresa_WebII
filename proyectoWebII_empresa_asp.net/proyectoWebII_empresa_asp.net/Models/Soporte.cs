namespace proyectoWebII_empresa_asp.net.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Soporte")]
    public partial class Soporte
    {
        public int id { get; set; }

        [StringLength(40)]
        public string Titulo_problema { get; set; }

        [StringLength(50)]
        public string Detalle_problema { get; set; }

        [StringLength(15)]
        public string resp_reportar_probl { get; set; }

        public int? id_cliente { get; set; }

        [StringLength(10)]
        public string estado_actual { get; set; }
    }
}

namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Oficina
    {
        [StringLength(15)]
        public string ID { get; set; }

        public int? cod_responsable_area { get; set; }

        public int? cod_responsable_ambiente { get; set; }

        [StringLength(200)]
        public string Descripcion { get; set; }

        [StringLength(9)]
        public string cod_act { get; set; }
    }
}

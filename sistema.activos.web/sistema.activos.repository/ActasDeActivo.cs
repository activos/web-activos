namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActasDeActivos")]
    public partial class ActasDeActivo
    {
        public ActasDeActivo()
        {
            Activos = new HashSet<Activo>();
            LogsTranferenciaActivos = new HashSet<LogsTranferenciaActivo>();
        }

        [StringLength(20)]
        public string ID { get; set; }

        public int NumeroActa { get; set; }

        public DateTime Fecha { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }

        public virtual ICollection<LogsTranferenciaActivo> LogsTranferenciaActivos { get; set; }
    }
}

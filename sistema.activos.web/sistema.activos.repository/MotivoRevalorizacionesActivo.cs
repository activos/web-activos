namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoRevalorizacionesActivos")]
    public partial class MotivoRevalorizacionesActivo
    {
        public MotivoRevalorizacionesActivo()
        {
            RevalorizacionesActivos = new HashSet<RevalorizacionesActivo>();
        }

        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual ICollection<RevalorizacionesActivo> RevalorizacionesActivos { get; set; }
    }
}

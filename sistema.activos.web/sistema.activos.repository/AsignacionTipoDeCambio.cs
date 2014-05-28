namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AsignacionTipoDeCambio")]
    public partial class AsignacionTipoDeCambio
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(20)]
        public string ActivoID { get; set; }

        [StringLength(50)]
        public string TipoCambioID { get; set; }

        public virtual Activo Activo { get; set; }

        public virtual TipoCambio TipoCambio { get; set; }
    }
}

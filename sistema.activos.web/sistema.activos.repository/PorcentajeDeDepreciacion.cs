namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PorcentajeDeDepreciacion")]
    public partial class PorcentajeDeDepreciacion
    {
        public PorcentajeDeDepreciacion()
        {
            Activos = new HashSet<Activo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Bienes { get; set; }

        public int? AnosVidaUtil { get; set; }

        public decimal? CoeficientePorcentaje { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }
    }
}

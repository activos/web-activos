namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoCambio")]
    public partial class TipoCambio
    {
        public TipoCambio()
        {
            AsignacionTipoDeCambios = new HashSet<AsignacionTipoDeCambio>();
        }

        [StringLength(50)]
        public string ID { get; set; }

        public DateTime FechaRegistro { get; set; }

        public decimal ValorBolivianos { get; set; }

        [Required]
        [StringLength(20)]
        public string UsuarioID { get; set; }

        public decimal? ValorDolares { get; set; }

        public decimal? ValorUFV { get; set; }

        public virtual ICollection<AsignacionTipoDeCambio> AsignacionTipoDeCambios { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}

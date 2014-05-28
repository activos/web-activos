namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturaActivos")]
    public partial class FacturaActivo
    {
        public FacturaActivo()
        {
            Activos = new HashSet<Activo>();
        }

        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string NIT { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroOrder { get; set; }

        public decimal Importe { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroFormularioC31 { get; set; }

        public DateTime FechaFormularioC31 { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }
    }
}

namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BajasDeActivos")]
    public partial class BajasDeActivo
    {
        public BajasDeActivo()
        {
            Activos = new HashSet<Activo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public DateTime? FechaIncorporacion { get; set; }

        public DateTime? FechaCompra { get; set; }

        public DateTime? FechaBaja { get; set; }

        [StringLength(50)]
        public string Resolucion { get; set; }

        [StringLength(50)]
        public string Observaciones { get; set; }

        public int? MotivoDeBajaID { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }

        public virtual MotivosDeBaja MotivosDeBaja { get; set; }
    }
}

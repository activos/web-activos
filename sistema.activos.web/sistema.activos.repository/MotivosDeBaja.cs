namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivosDeBaja")]
    public partial class MotivosDeBaja
    {
        public MotivosDeBaja()
        {
            BajasDeActivos = new HashSet<BajasDeActivo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Motivo { get; set; }

        public virtual ICollection<BajasDeActivo> BajasDeActivos { get; set; }
    }
}

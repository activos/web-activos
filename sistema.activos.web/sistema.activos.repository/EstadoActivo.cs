namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadoActivos")]
    public partial class EstadoActivo
    {
        public EstadoActivo()
        {
            Activos = new HashSet<Activo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("EstadoActivo")]
        [Required]
        [StringLength(50)]
        public string EstadoActivo1 { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }
    }
}

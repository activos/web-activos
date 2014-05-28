namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartidasPresupuestaria")]
    public partial class PartidasPresupuestaria
    {
        public PartidasPresupuestaria()
        {
            GrupoContables = new HashSet<GrupoContable>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NombrePartida { get; set; }

        public virtual ICollection<GrupoContable> GrupoContables { get; set; }
    }
}

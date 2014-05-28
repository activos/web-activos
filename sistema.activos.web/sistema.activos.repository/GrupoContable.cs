namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GrupoContable
    {
        public GrupoContable()
        {
            Activos = new HashSet<Activo>();
            AuxiliarContables = new HashSet<AuxiliarContable>();
            Auxiliares = new HashSet<Auxiliare>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string nombreGrupo { get; set; }

        public int VidaUtil { get; set; }

        public decimal ValorResidual { get; set; }

        [Required]
        [StringLength(4)]
        public string Referencia { get; set; }

        public int? PartidaID { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }

        public virtual ICollection<AuxiliarContable> AuxiliarContables { get; set; }

        public virtual ICollection<Auxiliare> Auxiliares { get; set; }

        public virtual PartidasPresupuestaria PartidasPresupuestaria { get; set; }
    }
}

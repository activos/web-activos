namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Auxiliare
    {
        public Auxiliare()
        {
            Activos = new HashSet<Activo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? GrupoContableID { get; set; }

        [StringLength(50)]
        public string NombreAuxliar { get; set; }

        [StringLength(5)]
        public string Referencia { get; set; }

        [StringLength(300)]
        public string Observaciones { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }

        public virtual GrupoContable GrupoContable { get; set; }
    }
}

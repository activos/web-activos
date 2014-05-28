namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoteActivos")]
    public partial class LoteActivo
    {
        public LoteActivo()
        {
            Activos = new HashSet<Activo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? Minimo { get; set; }

        public int? Maximo { get; set; }

        public DateTime? Fecha { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }
    }
}

namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Area")]
    public partial class Area
    {
        public Area()
        {
            Unidads = new HashSet<Unidad>();
            Unidads1 = new HashSet<Unidad>();
        }

        [StringLength(5)]
        public string ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int? Superintendencia { get; set; }

        public DateTime? Fecha { get; set; }

        public virtual ICollection<Unidad> Unidads { get; set; }

        public virtual ICollection<Unidad> Unidads1 { get; set; }
    }
}

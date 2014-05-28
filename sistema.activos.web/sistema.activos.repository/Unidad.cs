namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Unidad")]
    public partial class Unidad
    {
        public Unidad()
        {
            PuestoActuals = new HashSet<PuestoActual>();
        }

        [StringLength(5)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(5)]
        public string AreaID { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        public virtual Area Area { get; set; }

        public virtual Area Area1 { get; set; }

        public virtual ICollection<PuestoActual> PuestoActuals { get; set; }
    }
}

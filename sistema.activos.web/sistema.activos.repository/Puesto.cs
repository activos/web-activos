namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Puesto")]
    public partial class Puesto
    {
        public Puesto()
        {
            PuestoActuals = new HashSet<PuestoActual>();
        }

        [StringLength(5)]
        public string ID { get; set; }

        [StringLength(5)]
        public string CargoID { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? Superintendencia { get; set; }

        public short? Nivel { get; set; }

        public double? Salario { get; set; }

        [StringLength(5)]
        public string CodigoUnidad { get; set; }

        [StringLength(50)]
        public string Sigma { get; set; }

        public DateTime? Fecha { get; set; }

        public virtual Cargo Cargo { get; set; }

        public virtual Cargo Cargo1 { get; set; }

        public virtual ICollection<PuestoActual> PuestoActuals { get; set; }
    }
}

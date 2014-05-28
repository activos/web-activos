namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Accesorio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public decimal? Valor { get; set; }

        [StringLength(20)]
        public string ActivosID { get; set; }

        public virtual Activo Activo { get; set; }
    }
}

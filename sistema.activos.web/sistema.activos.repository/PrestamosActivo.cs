namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrestamosActivos")]
    public partial class PrestamosActivo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(20)]
        public string UsuarioID { get; set; }

        [StringLength(20)]
        public string ActivoID { get; set; }

        public DateTime? Fecha { get; set; }

        public int? RegionalesID { get; set; }

        public int? SW { get; set; }

        [StringLength(50)]
        public string Correlativo { get; set; }

        public virtual Activo Activo { get; set; }

        public virtual Regionale Regionale { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}

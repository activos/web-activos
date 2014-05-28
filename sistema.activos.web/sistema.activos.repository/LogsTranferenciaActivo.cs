namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogsTranferenciaActivos")]
    public partial class LogsTranferenciaActivo
    {
        [StringLength(50)]
        public string ID { get; set; }

        public DateTime FechaAsignacion { get; set; }

        [Required]
        [StringLength(20)]
        public string UsuarioIDTransfiere { get; set; }

        [Required]
        [StringLength(20)]
        public string UsuarioIDTransferido { get; set; }

        [Required]
        [StringLength(20)]
        public string ActivoID { get; set; }

        public DateTime FechaRecepcion { get; set; }

        public int Estado { get; set; }

        public int RegionalID { get; set; }

        [Required]
        [StringLength(20)]
        public string ActaActivoID { get; set; }

        public virtual ActasDeActivo ActasDeActivo { get; set; }

        public virtual Activo Activo { get; set; }

        public virtual Regionale Regionale { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Usuario Usuario1 { get; set; }
    }
}

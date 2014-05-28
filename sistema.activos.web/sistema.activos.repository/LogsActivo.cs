namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogsActivos")]
    public partial class LogsActivo
    {
        [StringLength(20)]
        public string ActivoID { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Accion { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(20)]
        public string UsuarioID { get; set; }

        [StringLength(50)]
        public string NumeroActa { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public virtual Activo Activo { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}

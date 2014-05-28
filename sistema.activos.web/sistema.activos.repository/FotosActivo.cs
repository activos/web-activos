namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FotosActivos")]
    public partial class FotosActivo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(300)]
        public string RutaDeAlmacenamiento { get; set; }

        [StringLength(20)]
        public string UsuarioID { get; set; }

        public DateTime? FechaSubida { get; set; }

        [StringLength(600)]
        public string Descripcion { get; set; }

        public double? Tamanio { get; set; }

        [StringLength(60)]
        public string Tipo { get; set; }

        [StringLength(20)]
        public string ActivoID { get; set; }

        public int? EstadoFoto { get; set; }

        public virtual Activo Activo { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}

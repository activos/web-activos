namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RevalorizacionesActivos")]
    public partial class RevalorizacionesActivo
    {
        [Required]
        [StringLength(20)]
        public string ActivoID { get; set; }

        public int? GrupoFinancieroID { get; set; }

        public int? AuxiliarContableID { get; set; }

        [StringLength(200)]
        public string Descripcion { get; set; }

        public int? VidaUtil { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime? FechaIncorporacion { get; set; }

        public DateTime? FechaCompra { get; set; }

        public decimal? Valor { get; set; }

        public int? FuenteID { get; set; }

        public int? OrganismoID { get; set; }

        public int? ProvinciaID { get; set; }

        public int? Condicion { get; set; }

        public int? Asignado { get; set; }

        [StringLength(1)]
        public string Revalorizado { get; set; }

        public int? FotoID { get; set; }

        public int? Lote { get; set; }

        public int? Usado { get; set; }

        [StringLength(6)]
        public string ReginailID { get; set; }

        [StringLength(15)]
        public string AmbienteID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(20)]
        public string MotivoRevalorizacionActivosID { get; set; }

        public virtual Activo Activo { get; set; }

        public virtual MotivoRevalorizacionesActivo MotivoRevalorizacionesActivo { get; set; }
    }
}

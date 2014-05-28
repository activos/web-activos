namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PuestoActual")]
    public partial class PuestoActual
    {
        public int PersonalID { get; set; }

        [StringLength(100)]
        public string Cargo { get; set; }

        [StringLength(100)]
        public string Puesto { get; set; }

        public DateTime? FechaIngreso { get; set; }

        [StringLength(50)]
        public string Resolucion { get; set; }

        [StringLength(50)]
        public string TipoContrato { get; set; }

        public DateTime? FechaInicioContrato { get; set; }

        [StringLength(50)]
        public string Duracion { get; set; }

        public int? NumeroContrato { get; set; }

        [StringLength(50)]
        public string FuenteFinanciamientoID { get; set; }

        [StringLength(50)]
        public string OrganismoFinanciadorID { get; set; }

        [StringLength(50)]
        public string CategoriaPrograma { get; set; }

        [StringLength(100)]
        public string AreaID { get; set; }

        [StringLength(50)]
        public string PartidaPresupuestariaID { get; set; }

        public short? Item { get; set; }

        public int? Categoria { get; set; }

        [StringLength(50)]
        public string NivelPuesto { get; set; }

        [StringLength(2)]
        public string PuestoCarrera { get; set; }

        public int? ModificacionIngreso { get; set; }

        [StringLength(50)]
        public string JornadaTrabajo { get; set; }

        public int? sw { get; set; }

        [StringLength(5)]
        public string CargoID { get; set; }

        [StringLength(5)]
        public string PuestoID { get; set; }

        [StringLength(5)]
        public string UnidadID { get; set; }

        public int? RegionalID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public virtual Cargo Cargo1 { get; set; }

        public virtual Puesto Puesto1 { get; set; }

        public virtual Unidad Unidad { get; set; }
    }
}

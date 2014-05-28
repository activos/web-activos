namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activos")]
    public partial class Activo
    {
        public Activo()
        {
            Accesorios = new HashSet<Accesorio>();
            AsignacionTipoDeCambios = new HashSet<AsignacionTipoDeCambio>();
            FotosActivos = new HashSet<FotosActivo>();
            LogsActivos = new HashSet<LogsActivo>();
            PrestamosActivos = new HashSet<PrestamosActivo>();
            RevalorizacionesActivos = new HashSet<RevalorizacionesActivo>();
            LogsTranferenciaActivos = new HashSet<LogsTranferenciaActivo>();
        }

        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        public int? VidaUtil { get; set; }

        public DateTime? FechaRegistrada { get; set; }

        public DateTime? FechaCompra { get; set; }

        public decimal? Precio { get; set; }

        public decimal? PrecioDolar { get; set; }

        public decimal? PrecioUFV { get; set; }

        [StringLength(20)]
        public string SerieActivo { get; set; }

        [StringLength(150)]
        public string NombreArchivoImagen { get; set; }

        [Required]
        [StringLength(20)]
        public string UsuarioID { get; set; }

        [Required]
        [StringLength(20)]
        public string FacturaID { get; set; }

        public int GrupoContableID { get; set; }

        public int AuxliarID { get; set; }

        public int EstadoActivoID { get; set; }

        public int ProveedorID { get; set; }

        public int? FuenteFinanciamientoID { get; set; }

        public int? OrganismoFinaciadorID { get; set; }

        public int? BajasDeActivoID { get; set; }

        public int? RegionalID { get; set; }

        public int? LoteActivoID { get; set; }

        [StringLength(20)]
        public string ActaDeActivoID { get; set; }

        public int? PorcentajeDeDepreciacionID { get; set; }

        [StringLength(4)]
        public string Garantia { get; set; }

        public virtual ICollection<Accesorio> Accesorios { get; set; }

        public virtual ActasDeActivo ActasDeActivo { get; set; }

        public virtual Auxiliare Auxiliare { get; set; }

        public virtual BajasDeActivo BajasDeActivo { get; set; }

        public virtual EstadoActivo EstadoActivo { get; set; }

        public virtual FacturaActivo FacturaActivo { get; set; }

        public virtual FuenteFinaciamiento FuenteFinaciamiento { get; set; }

        public virtual GrupoContable GrupoContable { get; set; }

        public virtual LoteActivo LoteActivo { get; set; }

        public virtual OrganismoFinanciador OrganismoFinanciador { get; set; }

        public virtual PorcentajeDeDepreciacion PorcentajeDeDepreciacion { get; set; }

        public virtual Proveedore Proveedore { get; set; }

        public virtual Regionale Regionale { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<AsignacionTipoDeCambio> AsignacionTipoDeCambios { get; set; }

        public virtual ICollection<FotosActivo> FotosActivos { get; set; }

        public virtual ICollection<LogsActivo> LogsActivos { get; set; }

        public virtual ICollection<PrestamosActivo> PrestamosActivos { get; set; }

        public virtual ICollection<RevalorizacionesActivo> RevalorizacionesActivos { get; set; }

        public virtual ICollection<LogsTranferenciaActivo> LogsTranferenciaActivos { get; set; }
    }
}

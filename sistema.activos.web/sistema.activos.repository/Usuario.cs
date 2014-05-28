namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuario
    {
        public Usuario()
        {
            Activos = new HashSet<Activo>();
            FotosActivos = new HashSet<FotosActivo>();
            LogsActivos = new HashSet<LogsActivo>();
            LogsTranferenciaActivos = new HashSet<LogsTranferenciaActivo>();
            LogsTranferenciaActivos1 = new HashSet<LogsTranferenciaActivo>();
            PrestamosActivos = new HashSet<PrestamosActivo>();
            TipoCambios = new HashSet<TipoCambio>();
        }

        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int Estado { get; set; }

        public int RegionalID { get; set; }

        [StringLength(20)]
        public string PersonalID { get; set; }

        public int? TipoUsuarioID { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }

        public virtual ICollection<FotosActivo> FotosActivos { get; set; }

        public virtual ICollection<LogsActivo> LogsActivos { get; set; }

        public virtual ICollection<LogsTranferenciaActivo> LogsTranferenciaActivos { get; set; }

        public virtual ICollection<LogsTranferenciaActivo> LogsTranferenciaActivos1 { get; set; }

        public virtual Personal Personal { get; set; }

        public virtual ICollection<PrestamosActivo> PrestamosActivos { get; set; }

        public virtual Regionale Regionale { get; set; }

        public virtual ICollection<TipoCambio> TipoCambios { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}

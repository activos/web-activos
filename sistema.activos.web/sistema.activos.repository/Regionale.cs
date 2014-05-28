namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Regionale
    {
        public Regionale()
        {
            Activos = new HashSet<Activo>();
            LogsTranferenciaActivos = new HashSet<LogsTranferenciaActivo>();
            PrestamosActivos = new HashSet<PrestamosActivo>();
            Usuarios = new HashSet<Usuario>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Sigla { get; set; }

        [Required]
        [StringLength(10)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(20)]
        public string ActivoID { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }

        public virtual ICollection<LogsTranferenciaActivo> LogsTranferenciaActivos { get; set; }

        public virtual ICollection<PrestamosActivo> PrestamosActivos { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}

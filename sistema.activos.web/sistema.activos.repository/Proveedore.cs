namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedore
    {
        public Proveedore()
        {
            Activos = new HashSet<Activo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(120)]
        public string Nombre { get; set; }

        [StringLength(120)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string CiudadProvincia { get; set; }

        public int? Telefono { get; set; }

        [StringLength(50)]
        public string Responsable { get; set; }

        public long? NIT { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }
    }
}

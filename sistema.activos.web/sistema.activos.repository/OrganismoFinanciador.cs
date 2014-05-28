namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganismoFinanciador")]
    public partial class OrganismoFinanciador
    {
        public OrganismoFinanciador()
        {
            Activos = new HashSet<Activo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Abreviacion { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public virtual ICollection<Activo> Activos { get; set; }
    }
}

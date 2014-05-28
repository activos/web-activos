namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cargo")]
    public partial class Cargo
    {
        public Cargo()
        {
            Puestoes = new HashSet<Puesto>();
            Puestoes1 = new HashSet<Puesto>();
            PuestoActuals = new HashSet<PuestoActual>();
        }

        [StringLength(5)]
        public string ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Categoria { get; set; }

        public int? ModalidadIncorporacion { get; set; }

        public int? Nivel { get; set; }

        public DateTime? Fecha { get; set; }

        public virtual ICollection<Puesto> Puestoes { get; set; }

        public virtual ICollection<Puesto> Puestoes1 { get; set; }

        public virtual ICollection<PuestoActual> PuestoActuals { get; set; }
    }
}

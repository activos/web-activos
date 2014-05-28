namespace sistema.activos.repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personal")]
    public partial class Personal
    {
        public Personal()
        {
            Usuarios = new HashSet<Usuario>();
        }

        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string TelefonoFijo { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}

namespace sistema.activos.repository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ActivosModel : DbContext
    {
        public ActivosModel()
            : base("name=ActivosModel")
        {
        }

        public virtual DbSet<Accesorio> Accesorios { get; set; }
        public virtual DbSet<ActasDeActivo> ActasDeActivos { get; set; }
        public virtual DbSet<Activo> Activos { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AsignacionTipoDeCambio> AsignacionTipoDeCambios { get; set; }
        public virtual DbSet<AuxiliarContable> AuxiliarContables { get; set; }
        public virtual DbSet<Auxiliare> Auxiliares { get; set; }
        public virtual DbSet<BajasDeActivo> BajasDeActivos { get; set; }
        public virtual DbSet<Cargo> Cargoes { get; set; }
        public virtual DbSet<EstadoActivo> EstadoActivos { get; set; }
        public virtual DbSet<FacturaActivo> FacturaActivos { get; set; }
        public virtual DbSet<FotosActivo> FotosActivos { get; set; }
        public virtual DbSet<FuenteFinaciamiento> FuenteFinaciamientoes { get; set; }
        public virtual DbSet<GrupoContable> GrupoContables { get; set; }
        public virtual DbSet<LogsActivo> LogsActivos { get; set; }
        public virtual DbSet<LogsTranferenciaActivo> LogsTranferenciaActivos { get; set; }
        public virtual DbSet<LoteActivo> LoteActivos { get; set; }
        public virtual DbSet<MotivoRevalorizacionesActivo> MotivoRevalorizacionesActivos { get; set; }
        public virtual DbSet<MotivosDeBaja> MotivosDeBajas { get; set; }
        public virtual DbSet<OrganismoFinanciador> OrganismoFinanciadors { get; set; }
        public virtual DbSet<PartidasPresupuestaria> PartidasPresupuestarias { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<PorcentajeDeDepreciacion> PorcentajeDeDepreciacions { get; set; }
        public virtual DbSet<PrestamosActivo> PrestamosActivos { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<Puesto> Puestoes { get; set; }
        public virtual DbSet<PuestoActual> PuestoActuals { get; set; }
        public virtual DbSet<Regionale> Regionales { get; set; }
        public virtual DbSet<RevalorizacionesActivo> RevalorizacionesActivos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TipoCambio> TipoCambios { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Unidad> Unidads { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Oficina> Oficinas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accesorio>()
                .Property(e => e.Valor)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ActasDeActivo>()
                .HasMany(e => e.Activos)
                .WithOptional(e => e.ActasDeActivo)
                .HasForeignKey(e => e.ActaDeActivoID);

            modelBuilder.Entity<ActasDeActivo>()
                .HasMany(e => e.LogsTranferenciaActivos)
                .WithRequired(e => e.ActasDeActivo)
                .HasForeignKey(e => e.ActaActivoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activo>()
                .Property(e => e.Precio)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Activo>()
                .Property(e => e.PrecioDolar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Activo>()
                .Property(e => e.PrecioUFV)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Activo>()
                .HasMany(e => e.Accesorios)
                .WithOptional(e => e.Activo)
                .HasForeignKey(e => e.ActivosID);

            modelBuilder.Entity<Activo>()
                .HasMany(e => e.RevalorizacionesActivos)
                .WithRequired(e => e.Activo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activo>()
                .HasMany(e => e.LogsTranferenciaActivos)
                .WithRequired(e => e.Activo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Area>()
                .HasMany(e => e.Unidads)
                .WithRequired(e => e.Area)
                .HasForeignKey(e => e.AreaID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Area>()
                .HasMany(e => e.Unidads1)
                .WithRequired(e => e.Area1)
                .HasForeignKey(e => e.AreaID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AsignacionTipoDeCambio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<AuxiliarContable>()
                .Property(e => e.Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Auxiliare>()
                .Property(e => e.Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Auxiliare>()
                .HasMany(e => e.Activos)
                .WithRequired(e => e.Auxiliare)
                .HasForeignKey(e => e.AuxliarID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cargo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cargo>()
                .Property(e => e.Categoria)
                .IsUnicode(false);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Puestoes)
                .WithOptional(e => e.Cargo)
                .HasForeignKey(e => e.CargoID);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Puestoes1)
                .WithOptional(e => e.Cargo1)
                .HasForeignKey(e => e.CargoID);

            modelBuilder.Entity<EstadoActivo>()
                .HasMany(e => e.Activos)
                .WithRequired(e => e.EstadoActivo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacturaActivo>()
                .Property(e => e.Importe)
                .HasPrecision(10, 2);

            modelBuilder.Entity<FacturaActivo>()
                .HasMany(e => e.Activos)
                .WithRequired(e => e.FacturaActivo)
                .HasForeignKey(e => e.FacturaID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FotosActivo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<FotosActivo>()
                .Property(e => e.UsuarioID)
                .IsUnicode(false);

            modelBuilder.Entity<FotosActivo>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<FuenteFinaciamiento>()
                .HasMany(e => e.Activos)
                .WithOptional(e => e.FuenteFinaciamiento)
                .HasForeignKey(e => e.FuenteFinanciamientoID);

            modelBuilder.Entity<GrupoContable>()
                .Property(e => e.ValorResidual)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GrupoContable>()
                .Property(e => e.Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GrupoContable>()
                .HasMany(e => e.Activos)
                .WithRequired(e => e.GrupoContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LogsActivo>()
                .Property(e => e.Accion)
                .IsUnicode(false);

            modelBuilder.Entity<LogsActivo>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<LogsActivo>()
                .Property(e => e.NumeroActa)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoRevalorizacionesActivo>()
                .HasMany(e => e.RevalorizacionesActivos)
                .WithOptional(e => e.MotivoRevalorizacionesActivo)
                .HasForeignKey(e => e.MotivoRevalorizacionActivosID);

            modelBuilder.Entity<MotivosDeBaja>()
                .HasMany(e => e.BajasDeActivos)
                .WithOptional(e => e.MotivosDeBaja)
                .HasForeignKey(e => e.MotivoDeBajaID);

            modelBuilder.Entity<OrganismoFinanciador>()
                .HasMany(e => e.Activos)
                .WithOptional(e => e.OrganismoFinanciador)
                .HasForeignKey(e => e.OrganismoFinaciadorID);

            modelBuilder.Entity<PartidasPresupuestaria>()
                .HasMany(e => e.GrupoContables)
                .WithOptional(e => e.PartidasPresupuestaria)
                .HasForeignKey(e => e.PartidaID);

            modelBuilder.Entity<PorcentajeDeDepreciacion>()
                .Property(e => e.Bienes)
                .IsUnicode(false);

            modelBuilder.Entity<PrestamosActivo>()
                .Property(e => e.Correlativo)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedore>()
                .HasMany(e => e.Activos)
                .WithRequired(e => e.Proveedore)
                .HasForeignKey(e => e.ProveedorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .Property(e => e.CodigoUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<Puesto>()
                .Property(e => e.Sigma)
                .IsUnicode(false);

            modelBuilder.Entity<Regionale>()
                .HasMany(e => e.Activos)
                .WithOptional(e => e.Regionale)
                .HasForeignKey(e => e.RegionalID);

            modelBuilder.Entity<Regionale>()
                .HasMany(e => e.LogsTranferenciaActivos)
                .WithRequired(e => e.Regionale)
                .HasForeignKey(e => e.RegionalID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Regionale>()
                .HasMany(e => e.PrestamosActivos)
                .WithOptional(e => e.Regionale)
                .HasForeignKey(e => e.RegionalesID);

            modelBuilder.Entity<Regionale>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Regionale)
                .HasForeignKey(e => e.RegionalID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RevalorizacionesActivo>()
                .Property(e => e.Valor)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RevalorizacionesActivo>()
                .Property(e => e.Revalorizado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RevalorizacionesActivo>()
                .Property(e => e.ReginailID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RevalorizacionesActivo>()
                .Property(e => e.AmbienteID)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCambio>()
                .Property(e => e.ValorBolivianos)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TipoCambio>()
                .Property(e => e.ValorDolares)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TipoCambio>()
                .Property(e => e.ValorUFV)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Activos)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.FotosActivos)
                .WithOptional(e => e.Usuario)
                .HasForeignKey(e => e.ActivoID);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.LogsTranferenciaActivos)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioIDTransfiere)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.LogsTranferenciaActivos1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioIDTransferido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.TipoCambios)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Oficina>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Oficina>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Oficina>()
                .Property(e => e.cod_act)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}

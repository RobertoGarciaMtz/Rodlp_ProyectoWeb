using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoWeb.Models
{
    public partial class rodlpContext : DbContext
    {
        private String connectionString;
        public rodlpContext( String _connectionString )
        {
            this.connectionString = _connectionString;
        }

        public rodlpContext(DbContextOptions<rodlpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CtClienteprovedor> CtClienteprovedor { get; set; }
        public virtual DbSet<CtFormaspago> CtFormaspago { get; set; }
        public virtual DbSet<CtGrupomovi> CtGrupomovi { get; set; }
        public virtual DbSet<CtIngresoegreso> CtIngresoegreso { get; set; }
        public virtual DbSet<CtMetodopago> CtMetodopago { get; set; }
        public virtual DbSet<CtMonedas> CtMonedas { get; set; }
        public virtual DbSet<CtProyecto> CtProyecto { get; set; }
        public virtual DbSet<CtTipocomprobante> CtTipocomprobante { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<TbCuentas> TbCuentas { get; set; }
        public virtual DbSet<TbEmpresa> TbEmpresa { get; set; }
        public virtual DbSet<TbFactura> TbFactura { get; set; }
        public virtual DbSet<TbImpuestos> TbImpuestos { get; set; }
        public virtual DbSet<TbInventario> TbInventario { get; set; }
        public virtual DbSet<TbMovimientos> TbMovimientos { get; set; }
        public virtual DbSet<TbPersonas> TbPersonas { get; set; }
        public virtual DbSet<TbStatus> TbStatus { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql( connectionString );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CtClienteprovedor>(entity =>
            {
                entity.HasKey(e => e.IdClienteProvedor)
                    .HasName("PRIMARY");

                entity.ToTable("ct_clienteprovedor");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status13_idx");

                entity.Property(e => e.IdClienteProvedor)
                    .HasColumnName("Id_ClienteProvedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CtClienteprovedor)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status13");
            });

            modelBuilder.Entity<CtFormaspago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago)
                    .HasName("PRIMARY");

                entity.ToTable("ct_formaspago");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.IdFormaPago)
                    .HasColumnName("Id_FormaPago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CtFormaspago)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status7");
            });

            modelBuilder.Entity<CtGrupomovi>(entity =>
            {
                entity.HasKey(e => e.IdGrupoMov)
                    .HasName("PRIMARY");

                entity.ToTable("ct_grupomovi");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.IdGrupoMov)
                    .HasColumnName("Id_GrupoMov")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CtGrupomovi)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status4");
            });

            modelBuilder.Entity<CtIngresoegreso>(entity =>
            {
                entity.HasKey(e => e.IdIe)
                    .HasName("PRIMARY");

                entity.ToTable("ct_ingresoegreso");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status15_idx");

                entity.Property(e => e.IdIe)
                    .HasColumnName("Id_IE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CtIngresoegreso)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status15");
            });

            modelBuilder.Entity<CtMetodopago>(entity =>
            {
                entity.HasKey(e => e.IdMetodo)
                    .HasName("PRIMARY");

                entity.ToTable("ct_metodopago");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.IdMetodo)
                    .HasColumnName("Id_Metodo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CtMetodopago)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status8");
            });

            modelBuilder.Entity<CtMonedas>(entity =>
            {
                entity.HasKey(e => e.IdMoneda)
                    .HasName("PRIMARY");

                entity.ToTable("ct_monedas");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.IdMoneda)
                    .HasColumnName("Id_Moneda")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CtMonedas)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status6");
            });

            modelBuilder.Entity<CtProyecto>(entity =>
            {
                entity.HasKey(e => e.IdProyectos)
                    .HasName("PRIMARY");

                entity.ToTable("ct_proyecto");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.IdProyectos)
                    .HasColumnName("Id_Proyectos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CtProyecto)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status10");
            });

            modelBuilder.Entity<CtTipocomprobante>(entity =>
            {
                entity.HasKey(e => e.IdComprobante)
                    .HasName("PRIMARY");

                entity.ToTable("ct_tipocomprobante");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.IdComprobante)
                    .HasColumnName("Id_Comprobante")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CtTipocomprobante)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status9");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.Edo)
                    .HasName("PRIMARY");

                entity.ToTable("estado");

                entity.Property(e => e.Edo).HasColumnType("int(11)");

                entity.Property(e => e.EdoActual)
                    .HasColumnName("edo_Actual")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbCuentas>(entity =>
            {
                entity.HasKey(e => e.IdCuenta)
                    .HasName("PRIMARY");

                entity.ToTable("tb_cuentas");

                entity.HasIndex(e => e.Grupo)
                    .HasName("Union_Grupo_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status3_idx");

                entity.Property(e => e.IdCuenta)
                    .HasColumnName("Id_Cuenta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Grupo).HasColumnType("int(11)");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.TbCuentas)
                    .HasForeignKey(d => d.Grupo)
                    .HasConstraintName("Union_Grupo");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.TbCuentas)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status3");
            });

            modelBuilder.Entity<TbEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PRIMARY");

                entity.ToTable("tb_empresa");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("Id_Empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ciudad)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Direccion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.TbEmpresa)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status2");
            });

            modelBuilder.Entity<TbFactura>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("PRIMARY");

                entity.ToTable("tb_factura");

                entity.Property(e => e.IdFactura)
                    .HasColumnName("id_factura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellidos)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.Emisor)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fecha)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbImpuestos>(entity =>
            {
                entity.HasKey(e => e.IdImpuesto)
                    .HasName("PRIMARY");

                entity.ToTable("tb_impuestos");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.IdImpuesto)
                    .HasColumnName("Id_Impuesto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreImpuesto)
                    .HasColumnName("Nombre_Impuesto")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.TbImpuestos)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status11");
            });

            modelBuilder.Entity<TbInventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario)
                    .HasName("PRIMARY");

                entity.ToTable("tb_inventario");

                entity.HasIndex(e => e.Empresa)
                    .HasName("Empresa_idx");

                entity.HasIndex(e => e.Estado)
                    .HasName("Estado_actual_idx");

                entity.HasIndex(e => e.ParaFactura)
                    .HasName("Facturas_idx");

                entity.Property(e => e.IdInventario)
                    .HasColumnName("Id_Inventario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Empresa).HasColumnType("int(11)");

                entity.Property(e => e.Estado).HasColumnType("int(11)");

                entity.Property(e => e.Matricula)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParaFactura)
                    .HasColumnName("Para_factura")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Vendedor)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p.TbInventario)
                    .HasForeignKey(d => d.Empresa)
                    .HasConstraintName("Empresa");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.TbInventario)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("Estado_actual");

                entity.HasOne(d => d.ParaFacturaNavigation)
                    .WithMany(p => p.TbInventario)
                    .HasForeignKey(d => d.ParaFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Facturas");
            });

            modelBuilder.Entity<TbMovimientos>(entity =>
            {
                entity.HasKey(e => e.Folio)
                    .HasName("PRIMARY");

                entity.ToTable("tb_movimientos");

                entity.HasIndex(e => e.IdCuenta)
                    .HasName("Union_Cuentas_idx");

                entity.HasIndex(e => e.IdEmpresas)
                    .HasName("Union_Empresas_idx");

                entity.HasIndex(e => e.IdFormPago)
                    .HasName("Union_FormaPago_idx");

                entity.HasIndex(e => e.IdMetodoPago)
                    .HasName("Union_MetodoPago_idx");

                entity.HasIndex(e => e.IdMonedas)
                    .HasName("Union_Monedas_idx");

                entity.HasIndex(e => e.IdPersonas)
                    .HasName("Union_Personas_idx");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("Union_Proyecto_idx");

                entity.HasIndex(e => e.IdTipoComprobante)
                    .HasName("Union_Comprobante_idx");

                entity.HasIndex(e => e.IngresoEgreso)
                    .HasName("Union_EI_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.Folio)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Concepto)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCuenta)
                    .HasColumnName("Id_Cuenta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresas)
                    .HasColumnName("Id_Empresas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFormPago)
                    .HasColumnName("Id_FormPago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMetodoPago)
                    .HasColumnName("Id_MetodoPago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMonedas)
                    .HasColumnName("Id_Monedas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMovimiento)
                    .HasColumnName("Id_Movimiento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPersonas)
                    .HasColumnName("Id_Personas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProyecto)
                    .HasColumnName("Id_Proyecto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTipoComprobante)
                    .HasColumnName("Id_TipoComprobante")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ieps).HasColumnName("IEPS");

                entity.Property(e => e.ImpuestosLocales)
                    .HasColumnName("Impuestos_locales")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IngresoEgreso)
                    .HasColumnName("Ingreso_Egreso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.PrecioUnitario).HasColumnName("Precio_Unitario");

                entity.Property(e => e.RetIsr).HasColumnName("Ret_ISR");

                entity.Property(e => e.RetIva).HasColumnName("Ret_IVA");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RutaArchivo)
                    .HasColumnName("Ruta_Archivo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasColumnType("varchar(35)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.IdCuenta)
                    .HasConstraintName("Union_Cuentas");

                entity.HasOne(d => d.IdEmpresasNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.IdEmpresas)
                    .HasConstraintName("Union_Empresas");

                entity.HasOne(d => d.IdFormPagoNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.IdFormPago)
                    .HasConstraintName("Union_FormaPago");

                entity.HasOne(d => d.IdMetodoPagoNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.IdMetodoPago)
                    .HasConstraintName("Union_MetodoPago");

                entity.HasOne(d => d.IdMonedasNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.IdMonedas)
                    .HasConstraintName("Union_Monedas");

                entity.HasOne(d => d.IdPersonasNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.IdPersonas)
                    .HasConstraintName("Union_Personas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.IdProyecto)
                    .HasConstraintName("Union_Proyecto");

                entity.HasOne(d => d.IdTipoComprobanteNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.IdTipoComprobante)
                    .HasConstraintName("Union_Comprobante");

                entity.HasOne(d => d.IngresoEgresoNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.IngresoEgreso)
                    .HasConstraintName("Union_EI");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.TbMovimientos)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status5");
            });

            modelBuilder.Entity<TbPersonas>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PRIMARY");

                entity.ToTable("tb_personas");

                entity.HasIndex(e => e.Status)
                    .HasName("Union_Status_idx");

                entity.Property(e => e.IdPersona)
                    .HasColumnName("Id_Persona")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteProveedor)
                    .HasColumnName("Cliente_Proveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Direccion)
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EMail)
                    .HasColumnName("E_mail")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Entidad)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Localidad)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Municipio)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreEmpresa)
                    .HasColumnName("Nombre_Empresa")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Telefono)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.TbPersonas)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Union_Status1");
            });

            modelBuilder.Entity<TbStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PRIMARY");

                entity.ToTable("tb_status");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("Id_Status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Status)
                    .HasName("Status_idx");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("Id_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contrasena)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NomUsuario)
                    .HasColumnName("Nom_usuario")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("Status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

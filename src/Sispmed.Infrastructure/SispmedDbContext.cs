using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sispmed.Web
{
    public partial class SispmedDbContext : DbContext
    {
        public SispmedDbContext()
        {
        }

        public SispmedDbContext(DbContextOptions<SispmedDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acompanantes> Acompanantes { get; set; }
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<CategoriasInsumos> CategoriasInsumos { get; set; }
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Convenios> Convenios { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<FailedJobs> FailedJobs { get; set; }
        public virtual DbSet<Gastos> Gastos { get; set; }
        public virtual DbSet<Hc> Hc { get; set; }
        public virtual DbSet<Insumos> Insumos { get; set; }
        public virtual DbSet<Kardex> Kardex { get; set; }
        public virtual DbSet<Migrations> Migrations { get; set; }
        public virtual DbSet<MovimientosInsumos> MovimientosInsumos { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<PasswordResets> PasswordResets { get; set; }
        public virtual DbSet<Procedimientos> Procedimientos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Recaudos> Recaudos { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Sedes> Sedes { get; set; }
        public virtual DbSet<Tarifas> Tarifas { get; set; }
        public virtual DbSet<TiposId> TiposId { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("database=Sispmed4;server=localhost;port=3306;user id=root;password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acompanantes>(entity =>
            {
                entity.ToTable("acompanantes");

                entity.HasIndex(e => e.NIdAcom)
                    .HasName("nIdAcom")
                    .IsUnique();

                entity.HasIndex(e => e.NIdPac)
                    .HasName("nIdPac");

                entity.HasIndex(e => e.TipoId)
                    .HasName("acompanantes_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Edad)
                    .HasColumnName("edad")
                    .HasColumnType("int(3)");

                entity.Property(e => e.MailAcom)
                    .HasColumnName("mailAcom")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NIdAcom)
                    .IsRequired()
                    .HasColumnName("nIdAcom")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NIdPac)
                    .IsRequired()
                    .HasColumnName("nIdPac")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.PApe)
                    .IsRequired()
                    .HasColumnName("pApe")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.PNom)
                    .IsRequired()
                    .HasColumnName("pNom")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ParPac)
                    .IsRequired()
                    .HasColumnName("parPac")
                    .HasMaxLength(30);

                entity.Property(e => e.SApe)
                    .IsRequired()
                    .HasColumnName("sApe")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.SNom)
                    .IsRequired()
                    .HasColumnName("sNom")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.TelAcom)
                    .IsRequired()
                    .HasColumnName("telAcom")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TipoId)
                    .IsRequired()
                    .HasColumnName("tipoId")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.NIdPacNavigation)
                    .WithMany(p => p.Acompanantes)
                    .HasPrincipalKey(p => p.NIdPac)
                    .HasForeignKey(d => d.NIdPac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("acompanantes_ibfk_2");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Acompanantes)
                    .HasPrincipalKey(p => p.TipoId)
                    .HasForeignKey(d => d.TipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("acompanante_tipoId");
            });

            modelBuilder.Entity<Agenda>(entity =>
            {
                entity.ToTable("agenda");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.HoraFinal)
                    .IsRequired()
                    .HasColumnName("hora_final")
                    .HasMaxLength(10);

                entity.Property(e => e.HoraInicio)
                    .IsRequired()
                    .HasColumnName("hora_inicio")
                    .HasMaxLength(10);

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Cargos>(entity =>
            {
                entity.ToTable("cargos");

                entity.HasIndex(e => e.NomCar)
                    .HasName("nomCar")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(2)");

                entity.Property(e => e.NomCar)
                    .IsRequired()
                    .HasColumnName("nomCar")
                    .HasMaxLength(20);

                entity.Property(e => e.SalCar)
                    .HasColumnName("salCar")
                    .HasColumnType("int(15)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<CategoriasInsumos>(entity =>
            {
                entity.ToTable("categorias_insumos");

                entity.HasIndex(e => e.NomCate)
                    .HasName("nomCate")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(2)");

                entity.Property(e => e.NomCate)
                    .IsRequired()
                    .HasColumnName("nomCate")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Citas>(entity =>
            {
                entity.HasKey(e => e.CodCita)
                    .HasName("PRIMARY");

                entity.ToTable("citas");

                entity.HasIndex(e => e.IdCita)
                    .HasName("id_cita")
                    .IsUnique();

                entity.HasIndex(e => e.NIdAcom)
                    .HasName("nIdAcom");

                entity.HasIndex(e => e.NIdPac)
                    .HasName("nIdPac");

                entity.HasIndex(e => e.NomIps)
                    .HasName("nomIPS");

                entity.HasIndex(e => e.NomProc)
                    .HasName("nomProc");

                entity.HasIndex(e => e.NomSede)
                    .HasName("nomSede");

                entity.Property(e => e.CodCita)
                    .HasColumnName("codCita")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EstCita)
                    .HasColumnName("estCita")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdCita)
                    .HasColumnName("id_cita")
                    .HasColumnType("int(3)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NIdAcom)
                    .HasColumnName("nIdAcom")
                    .HasMaxLength(15)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NIdPac)
                    .IsRequired()
                    .HasColumnName("nIdPac")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NomIps)
                    .IsRequired()
                    .HasColumnName("nomIPS")
                    .HasMaxLength(20);

                entity.Property(e => e.NomProc)
                    .IsRequired()
                    .HasColumnName("nomProc")
                    .HasMaxLength(30);

                entity.Property(e => e.NomSede)
                    .IsRequired()
                    .HasColumnName("nomSede")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Obs)
                    .HasColumnName("obs")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Convenios>(entity =>
            {
                entity.ToTable("convenios");

                entity.HasIndex(e => e.CodConv)
                    .HasName("codConv")
                    .IsUnique();

                entity.HasIndex(e => e.NomIps)
                    .HasName("nomIPS")
                    .IsUnique();

                entity.HasIndex(e => e.Resolu)
                    .HasName("resolu")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CodConv)
                    .IsRequired()
                    .HasColumnName("codConv")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CosConv)
                    .HasColumnName("cosConv")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DurConv)
                    .HasColumnName("durConv")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FecAper)
                    .HasColumnName("fecAper")
                    .HasColumnType("date");

                entity.Property(e => e.NomConv)
                    .IsRequired()
                    .HasColumnName("nomConv")
                    .HasMaxLength(20);

                entity.Property(e => e.NomIps)
                    .IsRequired()
                    .HasColumnName("nomIPS")
                    .HasMaxLength(20);

                entity.Property(e => e.ObjConv)
                    .IsRequired()
                    .HasColumnName("objConv")
                    .HasMaxLength(50);

                entity.Property(e => e.Resolu)
                    .IsRequired()
                    .HasColumnName("resolu")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.ToTable("empleados");

                entity.HasIndex(e => e.NIdEmp)
                    .HasName("nIdEmp")
                    .IsUnique();

                entity.HasIndex(e => e.NomCar)
                    .HasName("nomCar");

                entity.HasIndex(e => e.NomSede)
                    .HasName("nomSede");

                entity.HasIndex(e => e.TipoId)
                    .HasName("tipoId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Arl)
                    .IsRequired()
                    .HasColumnName("arl")
                    .HasMaxLength(20);

                entity.Property(e => e.CiuRes)
                    .IsRequired()
                    .HasColumnName("ciuRes")
                    .HasMaxLength(30);

                entity.Property(e => e.DirRes)
                    .IsRequired()
                    .HasColumnName("dirRes")
                    .HasMaxLength(30);

                entity.Property(e => e.ECivil)
                    .HasColumnName("eCivil")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Edad)
                    .HasColumnName("edad")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmailEmp)
                    .IsRequired()
                    .HasColumnName("emailEmp")
                    .HasMaxLength(30);

                entity.Property(e => e.Eps)
                    .IsRequired()
                    .HasColumnName("eps")
                    .HasMaxLength(20);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'''1'''");

                entity.Property(e => e.FecIng)
                    .HasColumnName("fecIng")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecNac)
                    .HasColumnName("fecNac")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasColumnName("genero")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NIdEmp)
                    .IsRequired()
                    .HasColumnName("nIdEmp")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NivlEdu)
                    .IsRequired()
                    .HasColumnName("nivlEdu")
                    .HasMaxLength(20);

                entity.Property(e => e.NomCar)
                    .IsRequired()
                    .HasColumnName("nomCar")
                    .HasMaxLength(20);

                entity.Property(e => e.NomSede)
                    .IsRequired()
                    .HasColumnName("nomSede")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.PApe)
                    .IsRequired()
                    .HasColumnName("pApe")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.PNom)
                    .IsRequired()
                    .HasColumnName("pNom")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Rh)
                    .IsRequired()
                    .HasColumnName("rh")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SApe)
                    .IsRequired()
                    .HasColumnName("sApe")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.SNom)
                    .HasColumnName("sNom")
                    .HasMaxLength(15)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelEmp)
                    .IsRequired()
                    .HasColumnName("telEmp")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TipoId)
                    .IsRequired()
                    .HasColumnName("tipoId")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.NomCarNavigation)
                    .WithMany(p => p.Empleados)
                    .HasPrincipalKey(p => p.NomRol)
                    .HasForeignKey(d => d.NomCar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("empleados_ibfk_4");

                entity.HasOne(d => d.NomSedeNavigation)
                    .WithMany(p => p.Empleados)
                    .HasPrincipalKey(p => p.NomSede)
                    .HasForeignKey(d => d.NomSede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("empleados_ibfk_3");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Empleados)
                    .HasPrincipalKey(p => p.TipoId)
                    .HasForeignKey(d => d.TipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("empleados_ibfk_1");
            });

            modelBuilder.Entity<Facturas>(entity =>
            {
                entity.HasKey(e => e.CodFact)
                    .HasName("PRIMARY");

                entity.ToTable("facturas");

                entity.HasIndex(e => e.CodCita)
                    .HasName("codCita");

                entity.HasIndex(e => e.IdFact)
                    .HasName("id_fact")
                    .IsUnique();

                entity.Property(e => e.CodFact)
                    .HasColumnName("codFact")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodCita)
                    .IsRequired()
                    .HasColumnName("codCita")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Concep)
                    .HasColumnName("concep")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdFact)
                    .HasColumnName("id_fact")
                    .HasColumnType("int(3)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<FailedJobs>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Connection)
                    .IsRequired()
                    .HasColumnName("connection");

                entity.Property(e => e.Exception)
                    .IsRequired()
                    .HasColumnName("exception")
                    .HasColumnType("longtext");

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnName("payload")
                    .HasColumnType("longtext");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnName("queue");
            });

            modelBuilder.Entity<Gastos>(entity =>
            {
                entity.ToTable("gastos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CodGasto)
                    .IsRequired()
                    .HasColumnName("codGasto")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Concep)
                    .IsRequired()
                    .HasColumnName("concep")
                    .HasMaxLength(50);

                entity.Property(e => e.FecGasto)
                    .HasColumnName("fecGasto")
                    .HasColumnType("date");

                entity.Property(e => e.ForPago)
                    .IsRequired()
                    .HasColumnName("forPago")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<Hc>(entity =>
            {
                entity.HasKey(e => e.IdConsulta)
                    .HasName("PRIMARY");

                entity.ToTable("hc");

                entity.HasIndex(e => e.NIdAcom)
                    .HasName("consulta_paciente_acompanante");

                entity.HasIndex(e => e.NIdPac)
                    .HasName("consulta_paciente");

                entity.Property(e => e.IdConsulta)
                    .HasColumnName("id_consulta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NIdAcom)
                    .IsRequired()
                    .HasColumnName("nIdAcom")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NIdPac)
                    .IsRequired()
                    .HasColumnName("nIdPac")
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Insumos>(entity =>
            {
                entity.ToTable("insumos");

                entity.HasIndex(e => e.CodIns)
                    .HasName("codIns")
                    .IsUnique();

                entity.HasIndex(e => e.NomCate)
                    .HasName("insumos_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(3)");

                entity.Property(e => e.CodIns)
                    .IsRequired()
                    .HasColumnName("codIns")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Concen)
                    .IsRequired()
                    .HasColumnName("concen")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FecVen)
                    .HasColumnName("fecVen")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Labora)
                    .IsRequired()
                    .HasColumnName("labora")
                    .HasMaxLength(20);

                entity.Property(e => e.NomCate)
                    .IsRequired()
                    .HasColumnName("nomCate")
                    .HasMaxLength(20);

                entity.Property(e => e.NomIns)
                    .IsRequired()
                    .HasColumnName("nomIns")
                    .HasMaxLength(20);

                entity.Property(e => e.PrecioU)
                    .HasColumnName("precioU")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Pres)
                    .IsRequired()
                    .HasColumnName("pres")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Unid)
                    .IsRequired()
                    .HasColumnName("unid")
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Kardex>(entity =>
            {
                entity.ToTable("kardex");

                entity.HasIndex(e => e.CodIns)
                    .HasName("codIns");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(3)");

                entity.Property(e => e.CodIns)
                    .IsRequired()
                    .HasColumnName("codIns")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Entradas)
                    .HasColumnName("entradas")
                    .HasColumnType("int(4)");

                entity.Property(e => e.PrecioU)
                    .HasColumnName("precioU")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Salidas)
                    .HasColumnName("salidas")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<Migrations>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Batch)
                    .HasColumnName("batch")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Migration)
                    .IsRequired()
                    .HasColumnName("migration")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MovimientosInsumos>(entity =>
            {
                entity.HasKey(e => e.CodMovi)
                    .HasName("PRIMARY");

                entity.ToTable("movimientos_insumos");

                entity.HasIndex(e => e.IdMovi)
                    .HasName("id_movi")
                    .IsUnique();

                entity.Property(e => e.CodMovi)
                    .HasColumnName("codMovi")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CodIns)
                    .IsRequired()
                    .HasColumnName("codIns")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Concep)
                    .IsRequired()
                    .HasColumnName("concep")
                    .HasMaxLength(50);

                entity.Property(e => e.FecMovi)
                    .HasColumnName("fecMovi")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdMovi)
                    .HasColumnName("id_movi")
                    .HasColumnType("int(3)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NIdEmp)
                    .IsRequired()
                    .HasColumnName("nIdEmp")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NIdProv)
                    .IsRequired()
                    .HasColumnName("nIdProv")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NomIns)
                    .IsRequired()
                    .HasColumnName("nomIns")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pacientes>(entity =>
            {
                entity.ToTable("pacientes");

                entity.HasIndex(e => e.NIdPac)
                    .HasName("nIdPac")
                    .IsUnique();

                entity.HasIndex(e => e.NomIps)
                    .HasName("nomIPS");

                entity.HasIndex(e => e.NomSede)
                    .HasName("nomSede");

                entity.HasIndex(e => e.TipoId)
                    .HasName("tipoId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DirResi)
                    .HasColumnName("dirResi")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ECivil)
                    .HasColumnName("eCivil")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Edad)
                    .HasColumnName("edad")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmailPac)
                    .HasColumnName("emailPac")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''Activo'''");

                entity.Property(e => e.FNaci)
                    .HasColumnName("fNaci")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Genero)
                    .HasColumnName("genero")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NIdPac)
                    .IsRequired()
                    .HasColumnName("nIdPac")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NomIps)
                    .IsRequired()
                    .HasColumnName("nomIPS")
                    .HasMaxLength(20);

                entity.Property(e => e.NomSede)
                    .IsRequired()
                    .HasColumnName("nomSede")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.PApe)
                    .IsRequired()
                    .HasColumnName("pApe")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.PNom)
                    .IsRequired()
                    .HasColumnName("pNom")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Regimen)
                    .IsRequired()
                    .HasColumnName("regimen")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Rh)
                    .HasColumnName("rh")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SApe)
                    .IsRequired()
                    .HasColumnName("sApe")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.SNom)
                    .HasColumnName("sNom")
                    .HasMaxLength(15)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelPac)
                    .IsRequired()
                    .HasColumnName("telPac")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TipoId)
                    .IsRequired()
                    .HasColumnName("tipoId")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PasswordResets>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasIndex(e => e.Email)
                    .HasName("password_resets_email_index");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Procedimientos>(entity =>
            {
                entity.ToTable("procedimientos");

                entity.HasIndex(e => e.CodProc)
                    .HasName("codProc")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(3)");

                entity.Property(e => e.CodProc)
                    .IsRequired()
                    .HasColumnName("codProc")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ConProc)
                    .HasColumnName("conProc")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.NomProc)
                    .IsRequired()
                    .HasColumnName("nomProc")
                    .HasMaxLength(30);

                entity.Property(e => e.ValProc)
                    .HasColumnName("valProc")
                    .HasColumnType("int(15)");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.NIdProv)
                    .HasName("PRIMARY");

                entity.ToTable("proveedores");

                entity.HasIndex(e => e.IdProv)
                    .HasName("id_prov")
                    .IsUnique();

                entity.HasIndex(e => e.TipoId)
                    .HasName("tipoId");

                entity.Property(e => e.NIdProv)
                    .HasColumnName("nIdProv")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.CiuProv)
                    .IsRequired()
                    .HasColumnName("ciuProv")
                    .HasMaxLength(20);

                entity.Property(e => e.ContProv)
                    .IsRequired()
                    .HasColumnName("contProv")
                    .HasMaxLength(20);

                entity.Property(e => e.DirProv)
                    .IsRequired()
                    .HasColumnName("dirProv")
                    .HasMaxLength(30);

                entity.Property(e => e.IdProv)
                    .HasColumnName("id_prov")
                    .HasColumnType("int(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MailProv)
                    .IsRequired()
                    .HasColumnName("mailProv")
                    .HasMaxLength(30);

                entity.Property(e => e.RSocial)
                    .IsRequired()
                    .HasColumnName("rSocial")
                    .HasMaxLength(20);

                entity.Property(e => e.TelProv)
                    .IsRequired()
                    .HasColumnName("telProv")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TipoId)
                    .IsRequired()
                    .HasColumnName("tipoId")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Recaudos>(entity =>
            {
                entity.ToTable("recaudos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CodReca)
                    .IsRequired()
                    .HasColumnName("codReca")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Concep)
                    .HasColumnName("concep")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecReca)
                    .HasColumnName("fecReca")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.HasIndex(e => e.NomRol)
                    .HasName("nomRol")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(1)");

                entity.Property(e => e.NomRol)
                    .IsRequired()
                    .HasColumnName("nomRol")
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sedes>(entity =>
            {
                entity.ToTable("sedes");

                entity.HasIndex(e => e.NomSede)
                    .HasName("nomSede")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(2)");

                entity.Property(e => e.DirSede)
                    .IsRequired()
                    .HasColumnName("dirSede")
                    .HasMaxLength(30);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomSede)
                    .IsRequired()
                    .HasColumnName("nomSede")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.TelSede)
                    .IsRequired()
                    .HasColumnName("telSede")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tarifas>(entity =>
            {
                entity.HasKey(e => e.IdTari)
                    .HasName("PRIMARY");

                entity.ToTable("tarifas");

                entity.HasIndex(e => e.NomTari)
                    .HasName("nomTari")
                    .IsUnique();

                entity.Property(e => e.IdTari)
                    .HasColumnName("id_tari")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CodTari)
                    .IsRequired()
                    .HasColumnName("codTari")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NomTari)
                    .IsRequired()
                    .HasColumnName("nomTari")
                    .HasMaxLength(20);

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<TiposId>(entity =>
            {
                entity.ToTable("tipos_id");

                entity.HasIndex(e => e.TipoId)
                    .HasName("tipoId")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(1)");

                entity.Property(e => e.NomTipo)
                    .IsRequired()
                    .HasColumnName("nomTipo")
                    .HasMaxLength(25);

                entity.Property(e => e.TipoId)
                    .IsRequired()
                    .HasColumnName("tipoId")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email)
                    .HasName("users_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'''1'''");

                entity.Property(e => e.NIdEmp)
                    .IsRequired()
                    .HasColumnName("nIdEmp")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.RememberToken)
                    .HasColumnName("remember_token")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.Usuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.IdUsua)
                    .HasName("id_usua")
                    .IsUnique();

                entity.HasIndex(e => e.NIdEmp)
                    .HasName("nIdEmp");

                entity.HasIndex(e => e.NomRol)
                    .HasName("nomRol");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(30);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdUsua)
                    .HasColumnName("id_usua")
                    .HasColumnType("int(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NIdEmp)
                    .IsRequired()
                    .HasColumnName("nIdEmp")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NomRol)
                    .IsRequired()
                    .HasColumnName("nomRol")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

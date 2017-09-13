using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ds.ServiciosWeb.datos
{
    public class DsDbContext: DbContext
    {

        public DsDbContext(DbContextOptions<DsDbContext> options)
            : base(options) { }



        //Ejemplo de la creación de los DbSet;

        //public virtual DbSet<ds.ServiciosWeb.entidades.Negocio.EntidadEjeplo> Ejemplo { get; set; }


        //Propiedades de navegación 
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Adscbdd>(entity =>
        //    {
        //        entity.HasKey(e => e.AdbdBdd)
        //            .HasName("PK_ADSCBDD");

        //        entity.ToTable("ADSCBDD");

        //        entity.Property(e => e.AdbdBdd)
        //            .HasColumnName("ADBD_BDD")
        //            .HasColumnType("varchar(32)");

        //        entity.Property(e => e.AdbdDescripcion)
        //            .HasColumnName("ADBD_DESCRIPCION")
        //            .HasColumnType("varchar(64)");

        //        entity.Property(e => e.AdbdServidor)
        //            .HasColumnName("ADBD_SERVIDOR")
        //            .HasColumnType("varchar(100)");
        //    });

        //    modelBuilder.Entity<Adscexe>(entity =>
        //    {
        //        entity.HasKey(e => new { e.AdexBdd, e.AdexGrupo, e.AdexSistema, e.AdexAplicacion })
        //            .HasName("PK_ADSCEXE_1");

        //        entity.ToTable("ADSCEXE");

        //        entity.Property(e => e.AdexBdd)
        //            .HasColumnName("ADEX_BDD")
        //            .HasColumnType("varchar(32)");

        //        entity.Property(e => e.AdexGrupo)
        //            .HasColumnName("ADEX_GRUPO")
        //            .HasColumnType("varchar(32)");

        //        entity.Property(e => e.AdexSistema)
        //            .HasColumnName("ADEX_SISTEMA")
        //            .HasColumnType("varchar(20)");

        //        entity.Property(e => e.AdexAplicacion)
        //            .HasColumnName("ADEX_APLICACION")
        //            .HasColumnType("varchar(30)");

        //        entity.Property(e => e.AdexSql)
        //            .HasColumnName("ADEX_SQL")
        //            .HasColumnType("varchar(4)");

        //        entity.Property(e => e.Del).HasColumnName("DEL");

        //        entity.Property(e => e.Ins).HasColumnName("INS");

        //        entity.Property(e => e.Sel).HasColumnName("SEL");

        //        entity.Property(e => e.Upd).HasColumnName("UPD");

        //        entity.HasOne(d => d.Adex)
        //            .WithMany(p => p.Adscexe)
        //            .HasForeignKey(d => new { d.AdexBdd, d.AdexGrupo })
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_ADSCEXE_ADSCGRP");

        //        entity.HasOne(d => d.AdexNavigation)
        //            .WithMany(p => p.Adscexe)
        //            .HasForeignKey(d => new { d.AdexSistema, d.AdexAplicacion })
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_ADSCEXE_ADSCMENU");
        //    });

        //    modelBuilder.Entity<Adscgrp>(entity =>
        //    {
        //        entity.HasKey(e => new { e.AdgrBdd, e.AdgrGrupo })
        //            .HasName("PK_ADSCGRP");

        //        entity.ToTable("ADSCGRP");

        //        entity.Property(e => e.AdgrBdd)
        //            .HasColumnName("ADGR_BDD")
        //            .HasColumnType("varchar(32)");

        //        entity.Property(e => e.AdgrGrupo)
        //            .HasColumnName("ADGR_GRUPO")
        //            .HasColumnType("varchar(32)");

        //        entity.Property(e => e.AdgrDescripcion)
        //            .HasColumnName("ADGR_DESCRIPCION")
        //            .HasColumnType("varchar(64)");

        //        entity.Property(e => e.AdgrNombre)
        //            .HasColumnName("ADGR_NOMBRE")
        //            .HasColumnType("varchar(32)");

        //        entity.HasOne(d => d.AdgrBddNavigation)
        //            .WithMany(p => p.Adscgrp)
        //            .HasForeignKey(d => d.AdgrBdd)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_ADSCGRP_ADSCBDD");
        //    });

        //}



    }




}







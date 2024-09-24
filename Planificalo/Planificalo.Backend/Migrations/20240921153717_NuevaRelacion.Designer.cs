﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Planificalo.Backend.Data;

#nullable disable

namespace Planificalo.Backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240921153717_NuevaRelacion")]
    partial class NuevaRelacion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Planificalo.Shared.Entities.Cotizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notas")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("Cotizaciones");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.CotizacionProducto", b =>
                {
                    b.Property<int>("CotizacionId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CotizacionId", "ProductoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("CotizacionProductos");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.CotizacionServicio", b =>
                {
                    b.Property<int>("CotizacionId")
                        .HasColumnType("int");

                    b.Property<int>("ServicioId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CotizacionId", "ServicioId");

                    b.HasIndex("ServicioId");

                    b.ToTable("CotizacionServicios");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Desistimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Aprobado")
                        .HasColumnType("bit");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Desistimientos");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoEventoId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.EventoInvitado", b =>
                {
                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<int>("InvitadoId")
                        .HasColumnType("int");

                    b.HasKey("EventoId", "InvitadoId");

                    b.ToTable("EventoInvitados");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Invitacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Confirmado")
                        .HasColumnType("bit");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEnvio")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvitadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Invitaciones");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Invitado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Confirmado")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Invitados");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Inventario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Calificacion")
                        .HasColumnType("float");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<long>("DocumentoIdentidad")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EsPersonaNatural")
                        .HasColumnType("bit");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelefonoContacto")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("TipoDocumento", "DocumentoIdentidad")
                        .IsUnique();

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.ProveedorProducto", b =>
                {
                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("ProveedorId", "ProductoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProveedorProductos");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.ProveedorServicio", b =>
                {
                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<int>("ServicioId")
                        .HasColumnType("int");

                    b.HasKey("ProveedorId", "ServicioId");

                    b.HasIndex("ServicioId");

                    b.ToTable("ProveedorServicios");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.TipoEvento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposEvento");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<long>("DocumentoIdentidad")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacionCuenta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("TipoDocumento", "DocumentoIdentidad")
                        .IsUnique();

                    b.ToTable("Usuarios");

                    b.HasDiscriminator().HasValue("Usuario");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Administrador", b =>
                {
                    b.HasBaseType("Planificalo.Shared.Entities.Usuario");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.UsuarioAnonimo", b =>
                {
                    b.HasBaseType("Planificalo.Shared.Entities.Usuario");

                    b.HasDiscriminator().HasValue("UsuarioAnonimo");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.UsuarioNormal", b =>
                {
                    b.HasBaseType("Planificalo.Shared.Entities.Usuario");

                    b.HasDiscriminator().HasValue("UsuarioNormal");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Cotizacion", b =>
                {
                    b.HasOne("Planificalo.Shared.Entities.Evento", "Evento")
                        .WithMany("Cotizaciones")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Planificalo.Shared.Entities.Proveedor", "Proveedor")
                        .WithMany("Cotizaciones")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.CotizacionProducto", b =>
                {
                    b.HasOne("Planificalo.Shared.Entities.Cotizacion", "Cotizacion")
                        .WithMany("CotizacionProductos")
                        .HasForeignKey("CotizacionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Planificalo.Shared.Entities.Producto", "Producto")
                        .WithMany("CotizacionProductos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cotizacion");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.CotizacionServicio", b =>
                {
                    b.HasOne("Planificalo.Shared.Entities.Cotizacion", "Cotizacion")
                        .WithMany("CotizacionServicios")
                        .HasForeignKey("CotizacionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Planificalo.Shared.Entities.Servicio", "Servicio")
                        .WithMany("CotizacionServicios")
                        .HasForeignKey("ServicioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cotizacion");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.ProveedorProducto", b =>
                {
                    b.HasOne("Planificalo.Shared.Entities.Producto", "Producto")
                        .WithMany("ProveedorProductos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Planificalo.Shared.Entities.Proveedor", "Proveedor")
                        .WithMany("ProveedorProductos")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.ProveedorServicio", b =>
                {
                    b.HasOne("Planificalo.Shared.Entities.Proveedor", "Proveedor")
                        .WithMany("ProveedorServicios")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Planificalo.Shared.Entities.Servicio", "Servicio")
                        .WithMany("ProveedorServicios")
                        .HasForeignKey("ServicioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Proveedor");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Cotizacion", b =>
                {
                    b.Navigation("CotizacionProductos");

                    b.Navigation("CotizacionServicios");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Evento", b =>
                {
                    b.Navigation("Cotizaciones");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Producto", b =>
                {
                    b.Navigation("CotizacionProductos");

                    b.Navigation("ProveedorProductos");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Proveedor", b =>
                {
                    b.Navigation("Cotizaciones");

                    b.Navigation("ProveedorProductos");

                    b.Navigation("ProveedorServicios");
                });

            modelBuilder.Entity("Planificalo.Shared.Entities.Servicio", b =>
                {
                    b.Navigation("CotizacionServicios");

                    b.Navigation("ProveedorServicios");
                });
#pragma warning restore 612, 618
        }
    }
}

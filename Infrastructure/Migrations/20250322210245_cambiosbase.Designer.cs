﻿// <auto-generated />
using System.Collections.Generic;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250322210245_cambiosbase")]
    partial class cambiosbase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Enemigo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("agilidad")
                        .HasColumnType("integer");

                    b.Property<int>("defensa")
                        .HasColumnType("integer");

                    b.Property<int>("energia")
                        .HasColumnType("integer");

                    b.Property<int>("fuerza")
                        .HasColumnType("integer");

                    b.Property<int>("inteligencia")
                        .HasColumnType("integer");

                    b.Property<int>("nivelAmenaza")
                        .HasColumnType("integer");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.PrimitiveCollection<List<string>>("recompensas")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<int>("salud")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Enemigo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Equipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("arma1Id")
                        .HasColumnType("integer");

                    b.Property<int>("arma2Id")
                        .HasColumnType("integer");

                    b.Property<int>("armaduraId")
                        .HasColumnType("integer");

                    b.Property<int>("cascoId")
                        .HasColumnType("integer");

                    b.Property<int>("grebasId")
                        .HasColumnType("integer");

                    b.Property<int>("guanteletesId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("arma1Id");

                    b.HasIndex("arma2Id");

                    b.HasIndex("armaduraId");

                    b.HasIndex("cascoId");

                    b.HasIndex("grebasId");

                    b.HasIndex("guanteletesId");

                    b.ToTable("Equipo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Estadistica", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("tipoEstadisticaId")
                        .HasColumnType("integer");

                    b.Property<int>("valor")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("tipoEstadisticaId");

                    b.ToTable("Estadistica", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Habilidad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Enemigoid")
                        .HasColumnType("integer");

                    b.Property<int>("ataqueBase")
                        .HasColumnType("integer");

                    b.Property<int>("costoEnergia")
                        .HasColumnType("integer");

                    b.Property<int>("costoMana")
                        .HasColumnType("integer");

                    b.Property<int>("costoSalud")
                        .HasColumnType("integer");

                    b.Property<int>("nivelRequerido")
                        .HasColumnType("integer");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("tiempoEnfriamiento")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.HasIndex("Enemigoid");

                    b.ToTable("Habilidads");
                });

            modelBuilder.Entity("Core.Entities.Mision", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.PrimitiveCollection<List<string>>("recompensas")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("id");

                    b.ToTable("Mision", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Objetivo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("completado")
                        .HasColumnType("boolean");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("misionId")
                        .HasColumnType("integer");

                    b.Property<int>("valorActual")
                        .HasColumnType("integer");

                    b.Property<int>("valorObjetivo")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("misionId");

                    b.ToTable("Objetivo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Objeto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.PrimitiveCollection<List<string>>("estadisticas")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("tipoObjetoId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("tipoObjetoId");

                    b.ToTable("Objeto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Personaje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("agilidadId")
                        .HasColumnType("integer");

                    b.Property<int>("defensaId")
                        .HasColumnType("integer");

                    b.Property<int>("energiaId")
                        .HasColumnType("integer");

                    b.Property<int?>("equipoId")
                        .HasColumnType("integer");

                    b.Property<int>("experiencia")
                        .HasColumnType("integer");

                    b.Property<int>("fuerzaId")
                        .HasColumnType("integer");

                    b.Property<int>("inteligenciaId")
                        .HasColumnType("integer");

                    b.Property<int>("nivel")
                        .HasColumnType("integer");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("saludId")
                        .HasColumnType("integer");

                    b.Property<int?>("tipoId")
                        .HasColumnType("integer");

                    b.Property<int?>("ubicacionId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("agilidadId");

                    b.HasIndex("defensaId");

                    b.HasIndex("energiaId");

                    b.HasIndex("fuerzaId");

                    b.HasIndex("inteligenciaId");

                    b.HasIndex("saludId");

                    b.HasIndex("tipoId");

                    b.HasIndex("ubicacionId");

                    b.ToTable("Personaje", (string)null);
                });

            modelBuilder.Entity("Core.Entities.PersonajeMision", b =>
                {
                    b.Property<int>("PersonajeId")
                        .HasColumnType("integer");

                    b.Property<int>("MisionId")
                        .HasColumnType("integer");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("Progreso")
                        .HasColumnType("integer");

                    b.HasKey("PersonajeId", "MisionId");

                    b.HasIndex("MisionId");

                    b.ToTable("PersoanjeMision", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ranura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("objetoId")
                        .HasColumnType("integer");

                    b.Property<int>("tipoObjetoId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("objetoId");

                    b.HasIndex("tipoObjetoId");

                    b.ToTable("Ranura", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoEstadistica", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("id");

                    b.ToTable("TipoEstadistica", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoObjeto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("id");

                    b.ToTable("TipoObjeto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoPersonaje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("id");

                    b.ToTable("TipoPersonajes");
                });

            modelBuilder.Entity("Core.Entities.Ubicacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("clima")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("id");

                    b.ToTable("Ubicacion", (string)null);
                });

            modelBuilder.Entity("HabilidadPersonaje", b =>
                {
                    b.Property<int>("habilidadesid")
                        .HasColumnType("integer");

                    b.Property<int>("personajesid")
                        .HasColumnType("integer");

                    b.HasKey("habilidadesid", "personajesid");

                    b.HasIndex("personajesid");

                    b.ToTable("HabilidadPersonaje");
                });

            modelBuilder.Entity("Core.Entities.Equipo", b =>
                {
                    b.HasOne("Core.Entities.Ranura", "arma1")
                        .WithMany()
                        .HasForeignKey("arma1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ranura", "arma2")
                        .WithMany()
                        .HasForeignKey("arma2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ranura", "armadura")
                        .WithMany()
                        .HasForeignKey("armaduraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ranura", "casco")
                        .WithMany()
                        .HasForeignKey("cascoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ranura", "grebas")
                        .WithMany()
                        .HasForeignKey("grebasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ranura", "guanteletes")
                        .WithMany()
                        .HasForeignKey("guanteletesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("arma1");

                    b.Navigation("arma2");

                    b.Navigation("armadura");

                    b.Navigation("casco");

                    b.Navigation("grebas");

                    b.Navigation("guanteletes");
                });

            modelBuilder.Entity("Core.Entities.Estadistica", b =>
                {
                    b.HasOne("Core.Entities.TipoEstadistica", "tipoEstadistica")
                        .WithMany()
                        .HasForeignKey("tipoEstadisticaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipoEstadistica");
                });

            modelBuilder.Entity("Core.Entities.Habilidad", b =>
                {
                    b.HasOne("Core.Entities.Enemigo", null)
                        .WithMany("habilidades")
                        .HasForeignKey("Enemigoid");
                });

            modelBuilder.Entity("Core.Entities.Objetivo", b =>
                {
                    b.HasOne("Core.Entities.Mision", null)
                        .WithMany("objetivos")
                        .HasForeignKey("misionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Objeto", b =>
                {
                    b.HasOne("Core.Entities.TipoObjeto", "tipoObjeto")
                        .WithMany()
                        .HasForeignKey("tipoObjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipoObjeto");
                });

            modelBuilder.Entity("Core.Entities.Personaje", b =>
                {
                    b.HasOne("Core.Entities.Estadistica", "agilidad")
                        .WithMany()
                        .HasForeignKey("agilidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Estadistica", "defensa")
                        .WithMany()
                        .HasForeignKey("defensaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Estadistica", "energia")
                        .WithMany()
                        .HasForeignKey("energiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Estadistica", "fuerza")
                        .WithMany()
                        .HasForeignKey("fuerzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Estadistica", "inteligencia")
                        .WithMany()
                        .HasForeignKey("inteligenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Estadistica", "salud")
                        .WithMany()
                        .HasForeignKey("saludId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("tipoId");

                    b.HasOne("Core.Entities.TipoPersonaje", "tipo")
                        .WithMany()
                        .HasForeignKey("tipoId");

                    b.HasOne("Core.Entities.Ubicacion", "ubicacion")
                        .WithMany()
                        .HasForeignKey("ubicacionId");

                    b.Navigation("agilidad");

                    b.Navigation("defensa");

                    b.Navigation("energia");

                    b.Navigation("equipo");

                    b.Navigation("fuerza");

                    b.Navigation("inteligencia");

                    b.Navigation("salud");

                    b.Navigation("tipo");

                    b.Navigation("ubicacion");
                });

            modelBuilder.Entity("Core.Entities.PersonajeMision", b =>
                {
                    b.HasOne("Core.Entities.Mision", "Mision")
                        .WithMany("PersonajeMisiones")
                        .HasForeignKey("MisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Personaje", "Personaje")
                        .WithMany("PersonajeMisiones")
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mision");

                    b.Navigation("Personaje");
                });

            modelBuilder.Entity("Core.Entities.Ranura", b =>
                {
                    b.HasOne("Core.Entities.Objeto", "objeto")
                        .WithMany()
                        .HasForeignKey("objetoId");

                    b.HasOne("Core.Entities.TipoObjeto", "tipoObjeto")
                        .WithMany()
                        .HasForeignKey("tipoObjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("objeto");

                    b.Navigation("tipoObjeto");
                });

            modelBuilder.Entity("HabilidadPersonaje", b =>
                {
                    b.HasOne("Core.Entities.Habilidad", null)
                        .WithMany()
                        .HasForeignKey("habilidadesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Personaje", null)
                        .WithMany()
                        .HasForeignKey("personajesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Enemigo", b =>
                {
                    b.Navigation("habilidades");
                });

            modelBuilder.Entity("Core.Entities.Mision", b =>
                {
                    b.Navigation("PersonajeMisiones");

                    b.Navigation("objetivos");
                });

            modelBuilder.Entity("Core.Entities.Personaje", b =>
                {
                    b.Navigation("PersonajeMisiones");
                });
#pragma warning restore 612, 618
        }
    }
}

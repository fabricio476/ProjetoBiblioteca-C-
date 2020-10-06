﻿// <auto-generated />
using System;
using BibliotecaWPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotecaWPF.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201005113105_EstanteinUsuario")]
    partial class EstanteinUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BibliotecaWPF.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edicao")
                        .HasColumnType("int");

                    b.Property<string>("Editora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstanteId")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isbn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroPaginas")
                        .HasColumnType("int");

                    b.Property<string>("TituloLivro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstanteId");

                    b.ToTable("Livros");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Livro");
                });

            modelBuilder.Entity("BibliotecaWPF.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("estanteId")
                        .HasColumnType("int");

                    b.Property<string>("senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("estanteId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BibliotecaWPF.Models.Estante", b =>
                {
                    b.HasBaseType("BibliotecaWPF.Models.Livro");

                    b.Property<string>("EstanteGenero")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Estantes");

                    b.HasDiscriminator().HasValue("Estante");
                });

            modelBuilder.Entity("BibliotecaWPF.Models.Livro", b =>
                {
                    b.HasOne("BibliotecaWPF.Models.Estante", null)
                        .WithMany("livros")
                        .HasForeignKey("EstanteId");
                });

            modelBuilder.Entity("BibliotecaWPF.Models.Usuario", b =>
                {
                    b.HasOne("BibliotecaWPF.Models.Estante", "estante")
                        .WithMany()
                        .HasForeignKey("estanteId");
                });
#pragma warning restore 612, 618
        }
    }
}
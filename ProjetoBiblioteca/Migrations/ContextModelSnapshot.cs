﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoBiblioteca.Model;

namespace ProjetoBiblioteca.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoBiblioteca.Model.Estante", b =>
                {
                    b.Property<int>("EstanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LivroIsbn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UsuarioCpf")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EstanteId");

                    b.HasIndex("LivroIsbn");

                    b.HasIndex("UsuarioCpf");

                    b.ToTable("Estante");
                });

            modelBuilder.Entity("ProjetoBiblioteca.Model.Livro", b =>
                {
                    b.Property<string>("Isbn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edicao")
                        .HasColumnType("int");

                    b.Property<string>("Editora")
                        .HasColumnType("nvarchar(max)");

<<<<<<< HEAD
                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

=======
>>>>>>> 9618c617a94abd971c4de925e307422be3bbb7b2
                    b.Property<int>("NumeroPaginas")
                        .HasColumnType("int");

                    b.Property<string>("TituloLivro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Isbn");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("ProjetoBiblioteca.Model.Usuario", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cpf");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoBiblioteca.Model.Estante", b =>
                {
                    b.HasOne("ProjetoBiblioteca.Model.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroIsbn");

                    b.HasOne("ProjetoBiblioteca.Model.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioCpf");
                });
#pragma warning restore 612, 618
        }
    }
}

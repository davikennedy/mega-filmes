﻿// <auto-generated />
using System;
using MegaFilmesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MegaFilmesAPI.Migrations
{
    [DbContext(typeof(FilmeContext))]
    partial class FilmeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MegaFilmesAPI.Models.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameAtor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Atores");
                });

            modelBuilder.Entity("MegaFilmesAPI.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Criterio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("MegaFilmesAPI.Models.Diretor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Diretores");
                });

            modelBuilder.Entity("MegaFilmesAPI.Models.Elenco", b =>
                {
                    b.Property<int>("IdElenco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PapelAtor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdElenco");

                    b.ToTable("Elencos");
                });

            modelBuilder.Entity("MegaFilmesAPI.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DiretorId")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DiretorId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("MegaFilmesAPI.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GeneroFilme")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("MegaFilmesAPI.Models.Filme", b =>
                {
                    b.HasOne("MegaFilmesAPI.Models.Diretor", "Diretor")
                        .WithMany("Filmes")
                        .HasForeignKey("DiretorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MegaFilmesAPI.Models.Genero", null)
                        .WithMany("Filmes")
                        .HasForeignKey("GeneroId");

                    b.Navigation("Diretor");
                });

            modelBuilder.Entity("MegaFilmesAPI.Models.Diretor", b =>
                {
                    b.Navigation("Filmes");
                });

            modelBuilder.Entity("MegaFilmesAPI.Models.Genero", b =>
                {
                    b.Navigation("Filmes");
                });
#pragma warning restore 612, 618
        }
    }
}

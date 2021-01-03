﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using do0.Data;

namespace do0.Migrations
{
    [DbContext(typeof(do0EventoContext))]
    partial class do0EventoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("do0.Models.do0Evento", b =>
                {
                    b.Property<int>("do0EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataEvento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("EnderecoCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Identidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeHomenageado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notas")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Rascunho")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ResponsavelEvento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone3")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoEvento")
                        .HasColumnType("TEXT");

                    b.Property<string>("do0Avatar")
                        .HasColumnType("TEXT");

                    b.Property<string>("do0User")
                        .HasColumnType("TEXT");

                    b.HasKey("do0EventoId");

                    b.ToTable("do0Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}

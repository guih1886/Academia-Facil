﻿// <auto-generated />
using System;
using AcademiaFacil.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcademiaFacil.Migrations
{
    [DbContext(typeof(AcademiaDBContext))]
    partial class AcademiaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AcademiaFacil.Models.Entidades.Aluno", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmacaoSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataProximoPagamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUltimoPagamento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DiaPagamentoPlano")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoPlano")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Entidades.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CREF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Equipamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ajuda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("RelacaoCargasId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RelacaoCargasId");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Exercicio", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Ajuda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Ativo")
                        .HasColumnType("bit");

                    b.Property<float>("Carga")
                        .HasColumnType("real");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EquipamentoId")
                        .HasColumnType("int");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Repeticoes")
                        .HasColumnType("int");

                    b.Property<int>("TipoExercicioId")
                        .HasColumnType("int");

                    b.Property<int?>("TreinoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipamentoId");

                    b.HasIndex("TipoExercicioId");

                    b.HasIndex("TreinoId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Tipos.RelacaoCargas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Relacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RelacaoCargas");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Tipos.TipoExercicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TiposExercicio");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Treino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<bool>("Publico")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Equipamento", b =>
                {
                    b.HasOne("AcademiaFacil.Models.Tipos.RelacaoCargas", "RelacaoCargas")
                        .WithMany()
                        .HasForeignKey("RelacaoCargasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RelacaoCargas");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Exercicio", b =>
                {
                    b.HasOne("AcademiaFacil.Models.Equipamento", "Equipamento")
                        .WithMany()
                        .HasForeignKey("EquipamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademiaFacil.Models.Tipos.TipoExercicio", "TipoExercicio")
                        .WithMany()
                        .HasForeignKey("TipoExercicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademiaFacil.Models.Treino", null)
                        .WithMany("Exercicios")
                        .HasForeignKey("TreinoId");

                    b.Navigation("Equipamento");

                    b.Navigation("TipoExercicio");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Treino", b =>
                {
                    b.HasOne("AcademiaFacil.Models.Entidades.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("AcademiaFacil.Models.Treino", b =>
                {
                    b.Navigation("Exercicios");
                });
#pragma warning restore 612, 618
        }
    }
}

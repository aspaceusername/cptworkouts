﻿// <auto-generated />
using System;
using CPTWorkouts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CPTWorkouts.Migrations
{
    [DbContext(typeof(CPTWorkoutsContext))]
    partial class CPTWorkoutsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CPTWorkouts.Models.Aulas", b =>
                {
                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateOnly>("Data")
                        .HasColumnType("date");

                    b.Property<int>("EquipaId")
                        .HasColumnType("int");

                    b.HasKey("Nome");

                    b.HasIndex("EquipaId");

                    b.ToTable("Aulas", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Clientes", b =>
                {
                    b.Property<int>("idClientes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idClientes"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dadosPessoais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("dataDeNascimento")
                        .HasColumnType("date");

                    b.HasKey("idClientes");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Compram", b =>
                {
                    b.Property<int>("idClientesFK")
                        .HasColumnType("int");

                    b.Property<int>("idServiçosFK")
                        .HasColumnType("int");

                    b.Property<int>("clienteidClientes")
                        .HasColumnType("int");

                    b.Property<string>("nomeServiços")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("servicoidServiço")
                        .HasColumnType("int");

                    b.HasKey("idClientesFK", "idServiçosFK");

                    b.HasIndex("clienteidClientes");

                    b.HasIndex("servicoidServiço");

                    b.ToTable("Compram", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Equipas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Logotype")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Equipas", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Faturas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Serviços")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idCliente")
                        .IsUnique();

                    b.ToTable("Faturas", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Inscrevem_se", b =>
                {
                    b.Property<int>("idClientesFK")
                        .HasColumnType("int");

                    b.Property<int>("idEquipasFK")
                        .HasColumnType("int");

                    b.Property<int>("ClienteidClientes")
                        .HasColumnType("int");

                    b.Property<int>("EquipaId")
                        .HasColumnType("int");

                    b.Property<string>("nomeEquipas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idClientesFK", "idEquipasFK");

                    b.HasIndex("ClienteidClientes");

                    b.HasIndex("EquipaId");

                    b.ToTable("Inscrevem_se", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Pertencem", b =>
                {
                    b.Property<int>("idTreinadoresFK")
                        .HasColumnType("int");

                    b.Property<int>("idEquipasFK")
                        .HasColumnType("int");

                    b.Property<int>("EquipaId")
                        .HasColumnType("int");

                    b.Property<int>("TreinadoridTreinadores")
                        .HasColumnType("int");

                    b.Property<string>("nomeEquipas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTreinadoresFK", "idEquipasFK");

                    b.HasIndex("EquipaId");

                    b.HasIndex("TreinadoridTreinadores");

                    b.ToTable("Pertencem", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Serviços", b =>
                {
                    b.Property<int>("idServiço")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idServiço"));

                    b.Property<int>("Preço")
                        .HasColumnType("int");

                    b.Property<string>("nomeServiço")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idServiço");

                    b.ToTable("Serviços", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Treinadores", b =>
                {
                    b.Property<int>("idTreinadores")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTreinadores"));

                    b.Property<string>("AulasNome")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Nome")
                        .HasColumnType("int");

                    b.HasKey("idTreinadores");

                    b.HasIndex("AulasNome");

                    b.ToTable("Treinadores", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("dataDeNascimento")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("CPTWorkouts.Models.Aulas", b =>
                {
                    b.HasOne("CPTWorkouts.Models.Equipas", "Equipa")
                        .WithMany("Aulas")
                        .HasForeignKey("EquipaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipa");
                });

            modelBuilder.Entity("CPTWorkouts.Models.Compram", b =>
                {
                    b.HasOne("CPTWorkouts.Models.Clientes", "cliente")
                        .WithMany("Serviços")
                        .HasForeignKey("clienteidClientes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CPTWorkouts.Models.Serviços", "servico")
                        .WithMany()
                        .HasForeignKey("servicoidServiço")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");

                    b.Navigation("servico");
                });

            modelBuilder.Entity("CPTWorkouts.Models.Faturas", b =>
                {
                    b.HasOne("CPTWorkouts.Models.Clientes", "Cliente")
                        .WithOne("Fatura")
                        .HasForeignKey("CPTWorkouts.Models.Faturas", "idCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CPTWorkouts.Models.Inscrevem_se", b =>
                {
                    b.HasOne("CPTWorkouts.Models.Clientes", "Cliente")
                        .WithMany("Equipas")
                        .HasForeignKey("ClienteidClientes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CPTWorkouts.Models.Equipas", "Equipa")
                        .WithMany("Clientes")
                        .HasForeignKey("EquipaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Equipa");
                });

            modelBuilder.Entity("CPTWorkouts.Models.Pertencem", b =>
                {
                    b.HasOne("CPTWorkouts.Models.Equipas", "Equipa")
                        .WithMany("Treinadores")
                        .HasForeignKey("EquipaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CPTWorkouts.Models.Treinadores", "Treinador")
                        .WithMany()
                        .HasForeignKey("TreinadoridTreinadores")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipa");

                    b.Navigation("Treinador");
                });

            modelBuilder.Entity("CPTWorkouts.Models.Treinadores", b =>
                {
                    b.HasOne("CPTWorkouts.Models.Aulas", null)
                        .WithMany("Treinadores")
                        .HasForeignKey("AulasNome");
                });

            modelBuilder.Entity("CPTWorkouts.Models.Aulas", b =>
                {
                    b.Navigation("Treinadores");
                });

            modelBuilder.Entity("CPTWorkouts.Models.Clientes", b =>
                {
                    b.Navigation("Equipas");

                    b.Navigation("Fatura")
                        .IsRequired();

                    b.Navigation("Serviços");
                });

            modelBuilder.Entity("CPTWorkouts.Models.Equipas", b =>
                {
                    b.Navigation("Aulas");

                    b.Navigation("Clientes");

                    b.Navigation("Treinadores");
                });
#pragma warning restore 612, 618
        }
    }
}

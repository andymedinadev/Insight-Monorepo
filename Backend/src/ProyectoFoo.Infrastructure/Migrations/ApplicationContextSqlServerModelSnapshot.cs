﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFoo.Infrastructure.Context;

#nullable disable

namespace ProyectoFoo.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContextSqlServer))]
    partial class ApplicationContextSqlServerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProyectoFoo.Domain.Entities.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ActualSymptoms")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("AdmissionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AgeRange")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .UseCollation("utf8_general_ci");

                    b.Property<string>("FailedActs")
                        .HasColumnType("longtext");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Interconsultation")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("KeyWords")
                        .HasColumnType("longtext");

                    b.Property<int?>("Modality")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("PatientEvolution")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PreferedContact")
                        .HasColumnType("longtext");

                    b.Property<string>("PreviousDiagnosis")
                        .HasColumnType("longtext");

                    b.Property<string>("PrincipalMotive")
                        .HasColumnType("longtext");

                    b.Property<string>("ProfesionalObservations")
                        .HasColumnType("longtext");

                    b.Property<string>("RecentEvents")
                        .HasColumnType("longtext");

                    b.Property<string>("SessionDay")
                        .HasColumnType("longtext");

                    b.Property<int?>("SessionDuration")
                        .HasColumnType("int");

                    b.Property<string>("SessionFrequency")
                        .HasColumnType("longtext");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TypeOfIdentification")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("ProyectoFoo.Domain.Entities.PatientMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("ActualizationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientMaterials");
                });

            modelBuilder.Entity("ProyectoFoo.Domain.Entities.PatientNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("ActualizationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientNotes");
                });

            modelBuilder.Entity("ProyectoFoo.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastAccesDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoFoo.Domain.Entities.VerificationCode", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Purpose")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId", "Code", "Purpose");

                    b.HasIndex("Expiry");

                    b.ToTable("VerificationCodes");
                });

            modelBuilder.Entity("ProyectoFoo.Domain.Entities.Paciente", b =>
                {
                    b.HasOne("ProyectoFoo.Domain.Entities.Usuario", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProyectoFoo.Domain.Entities.PatientMaterial", b =>
                {
                    b.HasOne("ProyectoFoo.Domain.Entities.Paciente", "Patient")
                        .WithMany("Materials")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ProyectoFoo.Domain.Entities.PatientNote", b =>
                {
                    b.HasOne("ProyectoFoo.Domain.Entities.Paciente", "Patient")
                        .WithMany("Notes")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ProyectoFoo.Domain.Entities.Paciente", b =>
                {
                    b.Navigation("Materials");

                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}

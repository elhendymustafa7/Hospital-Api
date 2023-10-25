﻿// <auto-generated />
using System;
using Hospital_Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital_Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital_Api.Model.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentID"));

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExaminationRoom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("PreNurseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("AppointmentID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientID");

                    b.HasIndex("PreNurseID");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Hospital_Api.Model.Block", b =>
                {
                    b.Property<int>("BlockCodeID")
                        .HasColumnType("int");

                    b.Property<int>("BlockFloorID")
                        .HasColumnType("int");

                    b.HasKey("BlockCodeID", "BlockFloorID");

                    b.HasAlternateKey("BlockCodeID");

                    b.ToTable("Block");
                });

            modelBuilder.Entity("Hospital_Api.Model.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Head")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Hospital_Api.Model.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SSN")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId")
                        .IsUnique();

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Hospital_Api.Model.Medication", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("Hospital_Api.Model.Nurse", b =>
                {
                    b.Property<int>("NurseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NurseID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Registered")
                        .HasColumnType("bit");

                    b.Property<int>("SSN")
                        .HasColumnType("int");

                    b.HasKey("NurseID");

                    b.HasIndex("SSN")
                        .IsUnique();

                    b.ToTable("Nurse");
                });

            modelBuilder.Entity("Hospital_Api.Model.Patient", b =>
                {
                    b.Property<int>("SSN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SSN"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("InsuranceID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("SSN");

                    b.HasIndex("DoctorID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("Hospital_Api.Model.Prescribe", b =>
                {
                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("MedicationID")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("Date")
                        .HasColumnType("time");

                    b.Property<int>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<string>("Dose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorID", "PatientID", "MedicationID", "Date");

                    b.HasIndex("AppointmentID");

                    b.HasIndex("MedicationID");

                    b.HasIndex("PatientID");

                    b.ToTable("Prescribe");
                });

            modelBuilder.Entity("Hospital_Api.Model.Procedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cost")
                        .IsUnique();

                    b.ToTable("Procedure");
                });

            modelBuilder.Entity("Hospital_Api.Model.Room", b =>
                {
                    b.Property<int>("RoomNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomNumber"));

                    b.Property<int>("BlockCodeID")
                        .HasColumnType("int");

                    b.Property<int>("BlockFloorID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("unavailable")
                        .HasColumnType("bit");

                    b.HasKey("RoomNumber");

                    b.HasAlternateKey("BlockCodeID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Hospital_Api.Model.Stay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly>("End")
                        .HasColumnType("time");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("Start")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("PatientID");

                    b.HasIndex("RoomId");

                    b.ToTable("Stay");
                });

            modelBuilder.Entity("Hospital_Api.Model.on_call", b =>
                {
                    b.Property<int>("NurseID")
                        .HasColumnType("int");

                    b.Property<int>("BlockCodeID")
                        .HasColumnType("int");

                    b.Property<int>("BlockFloorID")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("OnCallEnd")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("OnCallStart")
                        .HasColumnType("time");

                    b.HasKey("NurseID", "BlockCodeID", "BlockFloorID", "OnCallEnd", "OnCallStart");

                    b.HasIndex("BlockFloorID");

                    b.ToTable("on_call");
                });

            modelBuilder.Entity("Hospital_Api.Model.trained_in", b =>
                {
                    b.Property<int>("ProcedureID")
                        .HasColumnType("int");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CertificationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CertificationExpires")
                        .HasColumnType("datetime2");

                    b.HasKey("ProcedureID", "DoctorID");

                    b.HasIndex("DoctorID");

                    b.ToTable("trained_in");
                });

            modelBuilder.Entity("Hospital_Api.Model.Appointment", b =>
                {
                    b.HasOne("Hospital_Api.Model.Doctor", "doctor")
                        .WithMany("appointments")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital_Api.Model.Patient", "Patient")
                        .WithMany("appointments")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital_Api.Model.Nurse", "nurse")
                        .WithMany("appointments")
                        .HasForeignKey("PreNurseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("doctor");

                    b.Navigation("nurse");
                });

            modelBuilder.Entity("Hospital_Api.Model.Doctor", b =>
                {
                    b.HasOne("Hospital_Api.Model.Department", "Department")
                        .WithOne("Doctor")
                        .HasForeignKey("Hospital_Api.Model.Doctor", "DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hospital_Api.Model.Patient", b =>
                {
                    b.HasOne("Hospital_Api.Model.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Hospital_Api.Model.Prescribe", b =>
                {
                    b.HasOne("Hospital_Api.Model.Appointment", "appointment")
                        .WithMany("prescribes")
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital_Api.Model.Doctor", "doctor")
                        .WithMany("prescribes")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital_Api.Model.Medication", "medication")
                        .WithMany("prescribes")
                        .HasForeignKey("MedicationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital_Api.Model.Patient", "patient")
                        .WithMany("prescribes")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("appointment");

                    b.Navigation("doctor");

                    b.Navigation("medication");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Hospital_Api.Model.Room", b =>
                {
                    b.HasOne("Hospital_Api.Model.Block", "block")
                        .WithMany("rooms")
                        .HasForeignKey("BlockFloorID")
                        .HasPrincipalKey("BlockFloorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("block");
                });

            modelBuilder.Entity("Hospital_Api.Model.Stay", b =>
                {
                    b.HasOne("Hospital_Api.Model.Patient", "patient")
                        .WithMany("staies")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital_Api.Model.Room", "room")
                        .WithMany("staies")
                        .HasForeignKey("RoomId")
                        .HasPrincipalKey("BlockFloorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("patient");

                    b.Navigation("room");
                });

            modelBuilder.Entity("Hospital_Api.Model.on_call", b =>
                {
                    b.HasOne("Hospital_Api.Model.Block", "block")
                        .WithMany("on_Calls")
                        .HasForeignKey("BlockFloorID")
                        .HasPrincipalKey("BlockFloorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital_Api.Model.Nurse", "nurse")
                        .WithMany("on_Calls")
                        .HasForeignKey("NurseID")
                        .HasPrincipalKey("SSN")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("block");

                    b.Navigation("nurse");
                });

            modelBuilder.Entity("Hospital_Api.Model.trained_in", b =>
                {
                    b.HasOne("Hospital_Api.Model.Doctor", "Doctor")
                        .WithMany("trained_ins")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital_Api.Model.Procedure", "Procedure")
                        .WithMany("trained_ins")
                        .HasForeignKey("ProcedureID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Procedure");
                });

            modelBuilder.Entity("Hospital_Api.Model.Appointment", b =>
                {
                    b.Navigation("prescribes");
                });

            modelBuilder.Entity("Hospital_Api.Model.Block", b =>
                {
                    b.Navigation("on_Calls");

                    b.Navigation("rooms");
                });

            modelBuilder.Entity("Hospital_Api.Model.Department", b =>
                {
                    b.Navigation("Doctor")
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital_Api.Model.Doctor", b =>
                {
                    b.Navigation("Patients");

                    b.Navigation("appointments");

                    b.Navigation("prescribes");

                    b.Navigation("trained_ins");
                });

            modelBuilder.Entity("Hospital_Api.Model.Medication", b =>
                {
                    b.Navigation("prescribes");
                });

            modelBuilder.Entity("Hospital_Api.Model.Nurse", b =>
                {
                    b.Navigation("appointments");

                    b.Navigation("on_Calls");
                });

            modelBuilder.Entity("Hospital_Api.Model.Patient", b =>
                {
                    b.Navigation("appointments");

                    b.Navigation("prescribes");

                    b.Navigation("staies");
                });

            modelBuilder.Entity("Hospital_Api.Model.Procedure", b =>
                {
                    b.Navigation("trained_ins");
                });

            modelBuilder.Entity("Hospital_Api.Model.Room", b =>
                {
                    b.Navigation("staies");
                });
#pragma warning restore 612, 618
        }
    }
}

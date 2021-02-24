﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(WebApplication2Context))]
    partial class WebApplication2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("WebApplication2.Models.Fee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("PaidOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PeePaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StudentProfileid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentProfileid");

                    b.ToTable("Fees");
                });

            modelBuilder.Entity("WebApplication2.Models.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("English")
                        .HasColumnType("int");

                    b.Property<int>("Hindi")
                        .HasColumnType("int");

                    b.Property<int>("Maths")
                        .HasColumnType("int");

                    b.Property<int>("StudentProfileid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentProfileid");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("WebApplication2.Models.StudentProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FatehrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HallTicket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PayableFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PreviousSchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentProfiles");
                });

            modelBuilder.Entity("WebApplication2.Models.Fee", b =>
                {
                    b.HasOne("WebApplication2.Models.StudentProfile", "StudentProfile")
                        .WithMany("Fee")
                        .HasForeignKey("StudentProfileid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentProfile");
                });

            modelBuilder.Entity("WebApplication2.Models.Mark", b =>
                {
                    b.HasOne("WebApplication2.Models.StudentProfile", "StudentProfile")
                        .WithMany("Mark")
                        .HasForeignKey("StudentProfileid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentProfile");
                });

            modelBuilder.Entity("WebApplication2.Models.StudentProfile", b =>
                {
                    b.Navigation("Fee");

                    b.Navigation("Mark");
                });
#pragma warning restore 612, 618
        }
    }
}
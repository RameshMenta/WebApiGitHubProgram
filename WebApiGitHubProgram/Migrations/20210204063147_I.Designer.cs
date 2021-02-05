﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiGitHubProgram.Data;

namespace WebApiGitHubProgram.Migrations
{
    [DbContext(typeof(WebApiGitHubProgramContext))]
    [Migration("20210204063147_I")]
    partial class I
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiGitHubProgram.Data.MyData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Sal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MyData");
                });

            modelBuilder.Entity("WebApiGitHubProgram.Data.MyTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MyTables");
                });

            modelBuilder.Entity("WebApiGitHubProgram.Data.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TitleID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("TitleID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebApiGitHubProgram.Data.Title", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TitleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            id = -1,
                            TitleDescription = "Mrs......"
                        },
                        new
                        {
                            id = -2,
                            TitleDescription = "Miss."
                        },
                        new
                        {
                            id = -3,
                            TitleDescription = "Mr."
                        });
                });

            modelBuilder.Entity("WebApiGitHubProgram.Data.Student", b =>
                {
                    b.HasOne("WebApiGitHubProgram.Data.Title", "Title")
                        .WithMany("Student")
                        .HasForeignKey("TitleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
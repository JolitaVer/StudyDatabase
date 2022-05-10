﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudyDatabase;

namespace StudyDatabase.Migrations
{
    [DbContext(typeof(StudyDbContext))]
    [Migration("20220510150429_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DepartamentLecture", b =>
                {
                    b.Property<Guid>("DepartamentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LecturesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DepartamentsId", "LecturesId");

                    b.HasIndex("LecturesId");

                    b.ToTable("DepartamentLecture");
                });

            modelBuilder.Entity("StudyDatabase.Departament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DepName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departaments");
                });

            modelBuilder.Entity("StudyDatabase.Lecture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LectureTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("StudyDatabase.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DepartamentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DepartamentLecture", b =>
                {
                    b.HasOne("StudyDatabase.Departament", null)
                        .WithMany()
                        .HasForeignKey("DepartamentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyDatabase.Lecture", null)
                        .WithMany()
                        .HasForeignKey("LecturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudyDatabase.Student", b =>
                {
                    b.HasOne("StudyDatabase.Departament", null)
                        .WithMany("Students")
                        .HasForeignKey("DepartamentId");
                });

            modelBuilder.Entity("StudyDatabase.Departament", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}

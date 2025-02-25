﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Infrastructure.DataAcces;

#nullable disable

namespace School.Infrastructure.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20250220001549_AddStudents")]
    partial class AddStudents
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("School.Domain.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("School.Domain.Entities.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("School.Domain.Entities.Grade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRecorded")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EnrollmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Score")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("School.Domain.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DNI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("703d5c54-af34-4e85-8f6f-41c876beed01"),
                            CreatedDate = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000001",
                            Email = "juan.perez1@school.com",
                            LastName = "Pérez",
                            Name = "Juan",
                            Phone = "3000000001",
                            Semester = 1,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("38f93952-6546-4de5-997f-274591d4e5e5"),
                            CreatedDate = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000002",
                            Email = "ana.gomez2@school.com",
                            LastName = "Gómez",
                            Name = "Ana",
                            Phone = "3000000002",
                            Semester = 1,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("8143a3cb-6e43-4bd3-89ad-9f2f9a54cd53"),
                            CreatedDate = new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000003",
                            Email = "carlos.rodriguez3@school.com",
                            LastName = "Rodríguez",
                            Name = "Carlos",
                            Phone = "3000000003",
                            Semester = 2,
                            State = 1
                        },
                        new
                        {
                            Id = new Guid("7aa89fb6-a269-42ad-a2af-b25c72707ce5"),
                            CreatedDate = new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000004",
                            Email = "laura.fernandez4@school.com",
                            LastName = "Fernández",
                            Name = "Laura",
                            Phone = "3000000004",
                            Semester = 2,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("b51e4cf9-1a32-445b-9e0e-656296435254"),
                            CreatedDate = new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000005",
                            Email = "pedro.martinez5@school.com",
                            LastName = "Martínez",
                            Name = "Pedro",
                            Phone = "3000000005",
                            Semester = 3,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("916c3142-29bd-4615-9288-1d45e6203e3c"),
                            CreatedDate = new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000006",
                            Email = "lucia.sanchez6@school.com",
                            LastName = "Sánchez",
                            Name = "Lucía",
                            Phone = "3000000006",
                            Semester = 3,
                            State = 1
                        },
                        new
                        {
                            Id = new Guid("8d4cf676-8883-4ce0-9f04-1497665f5e00"),
                            CreatedDate = new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000007",
                            Email = "miguel.lopez7@school.com",
                            LastName = "López",
                            Name = "Miguel",
                            Phone = "3000000007",
                            Semester = 4,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("536e91e8-5f04-4e23-9000-1b2c6b13be2d"),
                            CreatedDate = new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000008",
                            Email = "sofia.diaz8@school.com",
                            LastName = "Díaz",
                            Name = "Sofía",
                            Phone = "3000000008",
                            Semester = 4,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("2d78bee5-5211-4d72-975c-c3264dc7814a"),
                            CreatedDate = new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000009",
                            Email = "andres.torres9@school.com",
                            LastName = "Torres",
                            Name = "Andrés",
                            Phone = "3000000009",
                            Semester = 5,
                            State = 1
                        },
                        new
                        {
                            Id = new Guid("f69ffc22-e69f-4be9-9869-b659a1156717"),
                            CreatedDate = new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000010",
                            Email = "maria.ruiz10@school.com",
                            LastName = "Ruiz",
                            Name = "María",
                            Phone = "3000000010",
                            Semester = 5,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("751f3bce-afa1-4c79-835a-23ed30d83c27"),
                            CreatedDate = new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000011",
                            Email = "javier.mendoza11@school.com",
                            LastName = "Mendoza",
                            Name = "Javier",
                            Phone = "3000000011",
                            Semester = 6,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("41c209a0-5a7c-4599-b04d-1b2ef628b814"),
                            CreatedDate = new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000012",
                            Email = "elena.ortiz12@school.com",
                            LastName = "Ortiz",
                            Name = "Elena",
                            Phone = "3000000012",
                            Semester = 6,
                            State = 1
                        },
                        new
                        {
                            Id = new Guid("d407e17e-148f-4d31-948d-e93b0addc9e1"),
                            CreatedDate = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000013",
                            Email = "diego.morales13@school.com",
                            LastName = "Morales",
                            Name = "Diego",
                            Phone = "3000000013",
                            Semester = 7,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("1d771062-8510-43ed-a960-223ff32e7563"),
                            CreatedDate = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000014",
                            Email = "valeria.gutierrez14@school.com",
                            LastName = "Gutiérrez",
                            Name = "Valeria",
                            Phone = "3000000014",
                            Semester = 7,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("4922b36e-911e-4982-9aa4-68233c7ec037"),
                            CreatedDate = new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000015",
                            Email = "jose.rios15@school.com",
                            LastName = "Ríos",
                            Name = "José",
                            Phone = "3000000015",
                            Semester = 8,
                            State = 1
                        },
                        new
                        {
                            Id = new Guid("86a00a92-4657-4ce5-a56b-b698c102c2c6"),
                            CreatedDate = new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000016",
                            Email = "natalia.silva16@school.com",
                            LastName = "Silva",
                            Name = "Natalia",
                            Phone = "3000000016",
                            Semester = 8,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("d56d7913-9048-42c6-bf74-9d5baf42c866"),
                            CreatedDate = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000017",
                            Email = "fernando.jimenez17@school.com",
                            LastName = "Jiménez",
                            Name = "Fernando",
                            Phone = "3000000017",
                            Semester = 9,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("522666ed-549b-4bc8-a42d-d1d9c0757c0b"),
                            CreatedDate = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000018",
                            Email = "paula.navarro18@school.com",
                            LastName = "Navarro",
                            Name = "Paula",
                            Phone = "3000000018",
                            Semester = 9,
                            State = 1
                        },
                        new
                        {
                            Id = new Guid("2b087ff7-1c74-41b0-acbf-15c7ff1fd43f"),
                            CreatedDate = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000019",
                            Email = "alejandro.cabrera19@school.com",
                            LastName = "Cabrera",
                            Name = "Alejandro",
                            Phone = "3000000019",
                            Semester = 10,
                            State = 0
                        },
                        new
                        {
                            Id = new Guid("d6cb3bf6-12d3-4180-96d2-d3dafb1566d2"),
                            CreatedDate = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DNI = "100000020",
                            Email = "camila.estrada20@school.com",
                            LastName = "Estrada",
                            Name = "Camila",
                            Phone = "3000000020",
                            Semester = 10,
                            State = 0
                        });
                });

            modelBuilder.Entity("School.Domain.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ContractType")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DNI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("School.Domain.Entities.Course", b =>
                {
                    b.HasOne("School.Domain.Entities.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("School.Domain.Entities.Enrollment", b =>
                {
                    b.HasOne("School.Domain.Entities.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("School.Domain.Entities.Grade", b =>
                {
                    b.HasOne("School.Domain.Entities.Enrollment", "Enrollment")
                        .WithMany("Grades")
                        .HasForeignKey("EnrollmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enrollment");
                });

            modelBuilder.Entity("School.Domain.Entities.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("School.Domain.Entities.Enrollment", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}

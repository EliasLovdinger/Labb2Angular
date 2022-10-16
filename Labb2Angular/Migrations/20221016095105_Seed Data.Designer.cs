﻿// <auto-generated />
using Labb2Angular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb2Angular.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221016095105_Seed Data")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb2Angular.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Economy",
                            Description = "Handles the companies invoices and invoicing"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Marketing",
                            Description = "Markets our product"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "It",
                            Description = "Fixes your computer when it breaks"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Support",
                            Description = "Help our customers to understand that they are wrong"
                        });
                });

            modelBuilder.Entity("Labb2Angular.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Adress = "Gata1231235",
                            DepartmentId = 1,
                            Email = "kalle@anka.se",
                            FirstName = "Kalle",
                            Gender = "Anka",
                            LastName = "Anka",
                            MobileNumber = "01231244",
                            Salary = 77777
                        },
                        new
                        {
                            EmployeeId = 2,
                            Adress = "Gata1231415",
                            DepartmentId = 2,
                            Email = "knatte@anka.se",
                            FirstName = "Knatte",
                            Gender = "Anka",
                            LastName = "Anka",
                            MobileNumber = "401243124",
                            Salary = 54233
                        },
                        new
                        {
                            EmployeeId = 3,
                            Adress = "Gata3132",
                            DepartmentId = 3,
                            Email = "tjatte@anka.se",
                            FirstName = "Tjatte",
                            Gender = "Anka",
                            LastName = "Anka",
                            MobileNumber = "1337411",
                            Salary = 27777
                        },
                        new
                        {
                            EmployeeId = 4,
                            Adress = "Gata51231",
                            DepartmentId = 4,
                            Email = "Fnatte@Hotmail.com",
                            FirstName = "Fnatte",
                            Gender = "Anka",
                            LastName = "Anka",
                            MobileNumber = "12312313",
                            Salary = 25555
                        },
                        new
                        {
                            EmployeeId = 5,
                            Adress = "Gata5123123121",
                            DepartmentId = 1,
                            Email = "Latte@Hotmail.com",
                            FirstName = "Latte",
                            Gender = "Anka",
                            LastName = "Anka",
                            MobileNumber = "123124667",
                            Salary = 25552
                        });
                });

            modelBuilder.Entity("Labb2Angular.Models.Employee", b =>
                {
                    b.HasOne("Labb2Angular.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Labb2Angular.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}

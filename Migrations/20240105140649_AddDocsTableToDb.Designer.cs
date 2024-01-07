﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hospital.Data;

#nullable disable

namespace hospital.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240105140649_AddDocsTableToDb")]
    partial class AddDocsTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hospital.Models.Appointments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("PatientAge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            id = 1,
                            PatientAge = "18",
                            PatientName = " Arun Kumar"
                        });
                });

            modelBuilder.Entity("hospital.Models.DocDb", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("FEES")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Docs");

                    b.HasData(
                        new
                        {
                            id = 1,
                            FEES = 2000,
                            description = "cardiologist",
                            name = " Arun Kumar"
                        },
                        new
                        {
                            id = 2,
                            FEES = 1500,
                            description = "dentist",
                            name = " Venugopal Iyer"
                        },
                        new
                        {
                            id = 3,
                            FEES = 800,
                            description = "General Physician",
                            name = "steve rogers"
                        },
                        new
                        {
                            id = 4,
                            FEES = 2500,
                            description = "Emergency OPD",
                            name = "Dr.Krishna Vasudev "
                        },
                        new
                        {
                            id = 5,
                            FEES = 3000,
                            description = "Dean",
                            name = "Dr.Tony Stark "
                        },
                        new
                        {
                            id = 6,
                            FEES = 500,
                            description = "Urologist",
                            name = "Dr.Natasha Ramonoff "
                        },
                        new
                        {
                            id = 7,
                            FEES = 800,
                            description = "Neurologist",
                            name = "Dr.Thor Odinson "
                        },
                        new
                        {
                            id = 8,
                            FEES = 600,
                            description = "physic",
                            name = "Dr.Bruce Banner "
                        });
                });

            modelBuilder.Entity("hospital.Models.dtabase", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("hospitals");

                    b.HasData(
                        new
                        {
                            id = 1,
                            description = "cardiologist",
                            name = " Arun Kumar"
                        },
                        new
                        {
                            id = 2,
                            description = "dentist",
                            name = " Venugopal Iyer"
                        },
                        new
                        {
                            id = 3,
                            description = "General Physician",
                            name = "steve rogers"
                        },
                        new
                        {
                            id = 4,
                            description = "Emergency OPD",
                            name = "Dr.Krishna Vasudev "
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelProject.DAL.Context;

#nullable disable

namespace TelProject.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TelProject.DATA.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressDetail = "YeşilYurt",
                            City = "Kastamonu",
                            CreateDate = new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(567),
                            PersonId = 1,
                            Status = 0,
                            Town = "Tosya"
                        },
                        new
                        {
                            Id = 2,
                            AddressDetail = "Karanfil",
                            City = "Ankara",
                            CreateDate = new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(570),
                            PersonId = 1,
                            Status = 0,
                            Town = "Gölbaşı"
                        },
                        new
                        {
                            Id = 3,
                            AddressDetail = "Taşyaka",
                            City = "Muğla",
                            CreateDate = new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(571),
                            PersonId = 2,
                            Status = 0,
                            Town = "Fethiye"
                        });
                });

            modelBuilder.Entity("TelProject.DATA.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(315),
                            FirstName = "Sefa",
                            LastName = "Attila",
                            Phone = "552 828 1903",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(323),
                            FirstName = "Ahmet",
                            LastName = "Yılmaz",
                            Phone = "552 828 1903",
                            Status = 0
                        });
                });

            modelBuilder.Entity("TelProject.DATA.Entities.Address", b =>
                {
                    b.HasOne("TelProject.DATA.Entities.Person", "Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("TelProject.DATA.Entities.Person", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}

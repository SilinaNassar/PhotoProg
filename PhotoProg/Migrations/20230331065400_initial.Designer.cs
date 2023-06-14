﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhotoProg.Models;

#nullable disable

namespace PhotoProg.Migrations
{
    [DbContext(typeof(PictureDbContext))]
    [Migration("20230331065400_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PhotoProg.Models.Picture", b =>
                {
                    b.Property<int>("PictureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PictureID"), 1L, 1);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PictureName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("PictureID");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            PictureID = 1,
                            FileName = "pecs1.jpg",
                            Location = "Pécs",
                            PictureName = "Panorama of Pécs",
                            When = new DateTime(2019, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PictureID = 2,
                            FileName = "pecs2.jpg",
                            Location = "Pécs",
                            PictureName = "Crypt of the Cathedral",
                            When = new DateTime(2018, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PictureID = 3,
                            FileName = "pecs3.jpg",
                            Location = "Pécs",
                            PictureName = "Havihegy church",
                            When = new DateTime(2017, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

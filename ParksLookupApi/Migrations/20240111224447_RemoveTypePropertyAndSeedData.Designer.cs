﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookupApi.Models;

#nullable disable

namespace ParksLookupApi.Migrations
{
    [DbContext(typeof(ParksLookupApiContext))]
    [Migration("20240111224447_RemoveTypePropertyAndSeedData")]
    partial class RemoveTypePropertyAndSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksLookupApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Location = "Oregon",
                            Name = "Crater Lake National Park"
                        },
                        new
                        {
                            ParkId = 2,
                            Location = "Oregon",
                            Name = "Champoeg State Park"
                        },
                        new
                        {
                            ParkId = 3,
                            Location = "Utah",
                            Name = "Zion National Park"
                        },
                        new
                        {
                            ParkId = 4,
                            Location = "Utah",
                            Name = "Arches National Park"
                        },
                        new
                        {
                            ParkId = 5,
                            Location = "California",
                            Name = "Yosemite National Park"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

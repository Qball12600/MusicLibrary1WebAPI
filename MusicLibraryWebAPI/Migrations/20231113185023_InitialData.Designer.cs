﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicLibraryWebAPI.Data;

#nullable disable

namespace MusicLibraryWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231113185023_InitialData")]
    partial class InitialData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MusicLibraryWebAPI.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "Mechanical Resonance",
                            Artist = "Tesla",
                            Genre = "Rock",
                            ReleaseDate = new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Modernday Cowboy"
                        },
                        new
                        {
                            Id = 2,
                            Album = "Mechanical Resonance",
                            Artist = "Tesla",
                            Genre = "Rock",
                            ReleaseDate = new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Modernday Cowboy"
                        },
                        new
                        {
                            Id = 3,
                            Album = "Mechanical Resonance",
                            Artist = "Tesla",
                            Genre = "Rock",
                            ReleaseDate = new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Modernday Cowboy"
                        },
                        new
                        {
                            Id = 4,
                            Album = "Mechanical Resonance",
                            Artist = "Tesla",
                            Genre = "Rock",
                            ReleaseDate = new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Modernday Cowboy"
                        },
                        new
                        {
                            Id = 5,
                            Album = "Mechanical Resonance",
                            Artist = "Tesla",
                            Genre = "Rock",
                            ReleaseDate = new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Modernday Cowboy"
                        },
                        new
                        {
                            Id = 6,
                            Album = "Mechanical Resonance",
                            Artist = "Tesla",
                            Genre = "Rock",
                            ReleaseDate = new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Modernday Cowboy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
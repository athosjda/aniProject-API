﻿// <auto-generated />
using Anime.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Anime.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Anime.Models.AiredTable", b =>
                {
                    b.Property<int>("AiredId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("from")
                        .HasColumnType("TEXT");

                    b.Property<string>("to")
                        .HasColumnType("TEXT");

                    b.HasKey("AiredId");

                    b.ToTable("Aired");
                });

            modelBuilder.Entity("Anime.Models.AnimeTable", b =>
                {
                    b.Property<int>("MalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Episodes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<double>("Score")
                        .HasColumnType("REAL");

                    b.Property<string>("Synopsis")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("TitleJapanese")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("MalId");

                    b.ToTable("Animes");
                });
#pragma warning restore 612, 618
        }
    }
}

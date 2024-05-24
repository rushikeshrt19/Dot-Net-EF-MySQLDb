﻿// <auto-generated />
using Dot_Net_EF_MySqlDb.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dot_Net_EF_MySqlDb.API.Migrations
{
    [DbContext(typeof(ApplicationDbontext))]
    [Migration("20240524063244_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Dot_Net_EF_MySqlDb.API.Models.Domain.Difficulty", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Difficulty");
                });

            modelBuilder.Entity("Dot_Net_EF_MySqlDb.API.Models.Domain.Region", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("Dot_Net_EF_MySqlDb.API.Models.Domain.Walk", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DifficultyId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walk");
                });

            modelBuilder.Entity("Dot_Net_EF_MySqlDb.API.Models.Domain.Walk", b =>
                {
                    b.HasOne("Dot_Net_EF_MySqlDb.API.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dot_Net_EF_MySqlDb.API.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}

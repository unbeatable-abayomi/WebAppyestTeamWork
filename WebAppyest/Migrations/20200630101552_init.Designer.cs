﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppyest.Models;

namespace WebAppyest.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200630101552_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppyest.Models.Activities", b =>
                {
                    b.Property<long>("ActivitiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityManagerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ActivityNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("ActivityTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("End")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectTeam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Start")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivitiesId");

                    b.ToTable("ActivitiesTable");
                });

            modelBuilder.Entity("WebAppyest.Models.ActivityTitle", b =>
                {
                    b.Property<long>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityId");

                    b.ToTable("ActivityTitleTable");
                });
#pragma warning restore 612, 618
        }
    }
}

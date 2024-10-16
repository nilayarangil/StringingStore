﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StringingStore.Data;

#nullable disable

namespace StringingStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241014182432_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StringingStore.Models.Entities.StringJob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RacketModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StringName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StringPattern")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tension")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("stringJobs");
                });
#pragma warning restore 612, 618
        }
    }
}

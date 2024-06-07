﻿// <auto-generated />
using System;
using ApiStreamingUeceMy.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiStreamingUeceMy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiStreamingUeceMy.Domain.Model.Stream", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Arquivo")
                        .HasColumnType("bytea");

                    b.Property<string>("Link")
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Stream");
                });
#pragma warning restore 612, 618
        }
    }
}
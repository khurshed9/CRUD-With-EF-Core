﻿// <auto-generated />
using CrudWithEfCore.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CrudWithEfCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241005071339_change_all_properties_action")]
    partial class change_all_properties_action
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CrudWithEfCore.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("personsPrimaryKey");

                    b.ToTable("People", null, t =>
                        {
                            t.HasCheckConstraint("ageConstraint", "age > 10 and age < 60");
                        });

                    b.HasData(
                        new
                        {
                            Id = 20,
                            Age = 30,
                            Gender = "Male",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 21,
                            Age = 25,
                            Gender = "Female",
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = 22,
                            Age = 35,
                            Gender = "Male",
                            Name = "Mike Doe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

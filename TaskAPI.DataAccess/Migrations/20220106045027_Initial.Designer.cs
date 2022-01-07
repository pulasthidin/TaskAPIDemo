﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDBContext))]
    [Migration("20220106045027_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Pulasthi Dinusha"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Ruvini Suranika"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Rex"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Kitty"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2022, 1, 6, 10, 20, 26, 891, DateTimeKind.Local).AddTicks(9321),
                            Description = "Get some text books for school",
                            Due = new DateTime(2022, 1, 11, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(8403),
                            Status = 0,
                            Title = "Get books for school - DB"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Created = new DateTime(2022, 1, 6, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(8997),
                            Description = "Get vegitables for the week",
                            Due = new DateTime(2022, 1, 8, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(9000),
                            Status = 0,
                            Title = "Get vegitables - DB"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Created = new DateTime(2022, 1, 6, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(9004),
                            Description = "Water all the plants quickly",
                            Due = new DateTime(2022, 1, 9, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(9004),
                            Status = 0,
                            Title = "Water the plans - DB"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
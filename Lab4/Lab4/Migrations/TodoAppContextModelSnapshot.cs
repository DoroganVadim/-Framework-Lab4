﻿// <auto-generated />
using System;
using Lab3.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab3.Migrations
{
    [DbContext(typeof(TodoAppContext))]
    partial class TodoAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab3.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("Lab3.Models.Tag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("tags", (string)null);
                });

            modelBuilder.Entity("Lab3.Models.Task", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idCategory")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("idCategory");

                    b.ToTable("tasks", (string)null);
                });

            modelBuilder.Entity("TagTask", b =>
                {
                    b.Property<int>("tagsid")
                        .HasColumnType("int");

                    b.Property<int>("tasksid")
                        .HasColumnType("int");

                    b.HasKey("tagsid", "tasksid");

                    b.HasIndex("tasksid");

                    b.ToTable("TagTask", (string)null);
                });

            modelBuilder.Entity("Lab3.Models.Task", b =>
                {
                    b.HasOne("Lab3.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("idCategory");

                    b.Navigation("category");
                });

            modelBuilder.Entity("TagTask", b =>
                {
                    b.HasOne("Lab3.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("tagsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab3.Models.Task", null)
                        .WithMany()
                        .HasForeignKey("tasksid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

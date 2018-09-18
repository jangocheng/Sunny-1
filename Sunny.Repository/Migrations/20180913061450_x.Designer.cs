﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sunny.Repository;

namespace Sunny.Repository.Migrations
{
    [DbContext(typeof(EfDbContext))]
    [Migration("20180913061450_x")]
    partial class x
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Sunny.Repository.DbModel.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("CreaterId");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("UpdateTime");

                    b.Property<long>("UpdaterId");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Sunny.Repository.DbModel.Passage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("CreaterId");

                    b.Property<DateTime>("LastEditTime");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<long>("UpdaterId");

                    b.HasKey("Id");

                    b.ToTable("Passage");
                });

            modelBuilder.Entity("Sunny.Repository.DbModel.PassageCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CategoryId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("CreaterId");

                    b.Property<long>("PassageId");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("UpdateTime");

                    b.Property<long>("UpdaterId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PassageId");

                    b.ToTable("PassageCategory");
                });

            modelBuilder.Entity("Sunny.Repository.DbModel.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AAA");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("CreaterId");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("StudentName")
                        .HasMaxLength(15);

                    b.Property<string>("Test");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<long>("UpdaterId");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Sunny.Repository.DbModel.StudentAddress", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("CreaterId");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("State");

                    b.Property<long>("StudentId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<long>("UpdaterId");

                    b.Property<int>("Zipcode");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentAddress");
                });

            modelBuilder.Entity("Sunny.Repository.DbModel.PassageCategory", b =>
                {
                    b.HasOne("Sunny.Repository.DbModel.Category", "Category")
                        .WithMany("PassageCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sunny.Repository.DbModel.Passage", "Passage")
                        .WithMany("PassageCategories")
                        .HasForeignKey("PassageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sunny.Repository.DbModel.StudentAddress", b =>
                {
                    b.HasOne("Sunny.Repository.DbModel.Student", "Student")
                        .WithOne("Address")
                        .HasForeignKey("Sunny.Repository.DbModel.StudentAddress", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
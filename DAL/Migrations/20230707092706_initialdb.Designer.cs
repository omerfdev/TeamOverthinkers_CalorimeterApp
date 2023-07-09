﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230707092706_initialdb")]
    partial class initialdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Categories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryDescription")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Meyve"
                        });
                });

            modelBuilder.Entity("Entities.CategoryDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasLactose")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAllergen")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGlutenFree")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegaterian")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID")
                        .IsUnique();

                    b.ToTable("Category Details", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            HasLactose = false,
                            IsAllergen = false,
                            IsGlutenFree = false,
                            IsVegaterian = false
                        });
                });

            modelBuilder.Entity("Entities.Foods", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Calories")
                        .HasColumnType("decimal");

                    b.Property<decimal>("CarbonHydrateValue")
                        .HasColumnType("decimal");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FatValue")
                        .HasColumnType("decimal");

                    b.Property<string>("FoodDescription")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FoodImagePath")
                        .HasColumnType("nvarchar");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("ProteinValue")
                        .HasColumnType("decimal");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Foods", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Calories = 52m,
                            CarbonHydrateValue = 8.9m,
                            CategoryID = 1,
                            FatValue = 4.5m,
                            FoodName = "Elma",
                            ProteinValue = 3.7m
                        },
                        new
                        {
                            ID = 2,
                            Calories = 52m,
                            CarbonHydrateValue = 8.9m,
                            CategoryID = 1,
                            FatValue = 4.5m,
                            FoodName = "Muz",
                            ProteinValue = 3.7m
                        });
                });

            modelBuilder.Entity("Entities.Meal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Meals", (string)null);
                });

            modelBuilder.Entity("Entities.User_Food_Meal", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.Property<int>("MealID")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MealDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserID", "FoodID", "MealID");

                    b.HasIndex("FoodID");

                    b.HasIndex("MealID");

                    b.ToTable("User Food Meals", (string)null);
                });

            modelBuilder.Entity("Entities.UserDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<bool>("GlutenPreference")
                        .HasColumnType("bit");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAllergic")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLactoseIntolerant")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal");

                    b.HasKey("ID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("User Details", (string)null);
                });

            modelBuilder.Entity("Entities.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Entities.CategoryDetails", b =>
                {
                    b.HasOne("Entities.Categories", "Categories")
                        .WithOne("CategoryDetails")
                        .HasForeignKey("Entities.CategoryDetails", "CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Entities.Foods", b =>
                {
                    b.HasOne("Entities.Categories", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.User_Food_Meal", b =>
                {
                    b.HasOne("Entities.Foods", "Foods")
                        .WithMany("UsersMeals")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Meal", "Meals")
                        .WithMany("UsersMeals")
                        .HasForeignKey("MealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Users", "Users")
                        .WithMany("UsersMeals")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Foods");

                    b.Navigation("Meals");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.UserDetails", b =>
                {
                    b.HasOne("Entities.Users", "Users")
                        .WithOne("UserDetails")
                        .HasForeignKey("Entities.UserDetails", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Categories", b =>
                {
                    b.Navigation("CategoryDetails");

                    b.Navigation("Foods");
                });

            modelBuilder.Entity("Entities.Foods", b =>
                {
                    b.Navigation("UsersMeals");
                });

            modelBuilder.Entity("Entities.Meal", b =>
                {
                    b.Navigation("UsersMeals");
                });

            modelBuilder.Entity("Entities.Users", b =>
                {
                    b.Navigation("UserDetails");

                    b.Navigation("UsersMeals");
                });
#pragma warning restore 612, 618
        }
    }
}
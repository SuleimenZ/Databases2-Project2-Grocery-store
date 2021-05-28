﻿// <auto-generated />
using System;
using Databases_2_Project2_Grocery_store.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Databases_2_Project2_Grocery_store.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            modelBuilder.Entity("Databases_2_Project2_Grocery_store.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Databases_2_Project2_Grocery_store.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("boolean");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("Databases_2_Project2_Grocery_store.Models.Client", b =>
                {
                    b.HasBaseType("Databases_2_Project2_Grocery_store.Models.Person");

                    b.Property<bool>("LoyaltyProgram")
                        .HasColumnType("boolean");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            Birthday = new DateTime(1977, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "0fb07ba7-b4cc-4991-878e-556411561624",
                            EmailConfirmed = false,
                            FirstName = "Bob",
                            LastName = "Belcher",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aca6fdec-da97-4df7-b9a1-ad6ee5ec82c0",
                            TwoFactorEnabled = false,
                            LoyaltyProgram = true
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            Birthday = new DateTime(1954, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "5597bc42-ce97-48f5-8b18-44922bd5a29b",
                            EmailConfirmed = false,
                            FirstName = "Hank",
                            LastName = "Hill",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bee1a936-53f2-4baa-9740-d8d6a3ce4bef",
                            TwoFactorEnabled = false,
                            LoyaltyProgram = false
                        });
                });

            modelBuilder.Entity("Databases_2_Project2_Grocery_store.Models.Employee", b =>
                {
                    b.HasBaseType("Databases_2_Project2_Grocery_store.Models.Person");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            Birthday = new DateTime(1980, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "9b81b640-ea47-4243-97d1-ff75eefb5dd9",
                            EmailConfirmed = false,
                            FirstName = "Jace",
                            LastName = "Beleren",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fe92d666-169f-4410-ac07-2dc5a8e34f62",
                            TwoFactorEnabled = false,
                            HireDate = new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Poznan"
                        });
                });

            modelBuilder.Entity("Databases_2_Project2_Grocery_store.Models.Drink", b =>
                {
                    b.HasBaseType("Databases_2_Project2_Grocery_store.Models.Product");

                    b.Property<double>("Volume")
                        .HasColumnType("double precision");

                    b.HasDiscriminator().HasValue("Drink");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Available = true,
                            Name = "Tassay",
                            Price = 2.0,
                            Type = "Water",
                            Volume = 0.5
                        },
                        new
                        {
                            Id = 3,
                            Available = true,
                            Name = "Polmlek",
                            Price = 2.5,
                            Type = "Milk",
                            Volume = 1.0
                        },
                        new
                        {
                            Id = 4,
                            Available = true,
                            Name = "Orange Juice",
                            Price = 4.0,
                            Type = "Juice",
                            Volume = 1.0
                        });
                });

            modelBuilder.Entity("Databases_2_Project2_Grocery_store.Models.Food", b =>
                {
                    b.HasBaseType("Databases_2_Project2_Grocery_store.Models.Product");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasDiscriminator().HasValue("Food");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Available = true,
                            Name = "PanPiek",
                            Price = 3.0,
                            Type = "Bread",
                            Weight = 0.40000000000000002
                        },
                        new
                        {
                            Id = 5,
                            Available = true,
                            Name = "Red Apple",
                            Price = 2.5,
                            Type = "Fruit",
                            Weight = 1.0
                        });
                });

            modelBuilder.Entity("Databases_2_Project2_Grocery_store.Models.Client", b =>
                {
                    b.HasOne("Databases_2_Project2_Grocery_store.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Databases_2_Project2_Grocery_store.Models.Client", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Databases_2_Project2_Grocery_store.Models.Employee", b =>
                {
                    b.HasOne("Databases_2_Project2_Grocery_store.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Databases_2_Project2_Grocery_store.Models.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

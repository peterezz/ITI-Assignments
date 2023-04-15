﻿// <auto-generated />
using System;
using HotelManagment_Day11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagment_Day11.Migrations
{
    [DbContext(typeof(HotelManagmentContext))]
    [Migration("20230407172626_UpdatedReserverTables")]
    partial class UpdatedReserverTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelManagment_Day11.Models.Reserver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("apt_suite")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("birth_day")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("choices_id")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("gender_id")
                        .HasColumnType("int");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("number_guest")
                        .HasColumnType("int");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("state_id")
                        .HasColumnType("int");

                    b.Property<string>("street_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zip_code")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("choices_id");

                    b.HasIndex("gender_id");

                    b.HasIndex("state_id");

                    b.ToTable("Reservers");
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.ReserverChoices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("arrival_time")
                        .HasColumnType("datetime2");

                    b.Property<bool>("check_in")
                        .HasColumnType("bit");

                    b.Property<DateTime>("leaving_time")
                        .HasColumnType("datetime2");

                    b.Property<int>("resrver_id")
                        .HasColumnType("int");

                    b.Property<int>("room_floor")
                        .HasColumnType("int");

                    b.Property<string>("room_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("room_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("supply_status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ReserverChoices");
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.ReserverState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReserverState");
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.ResrverGender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ResrverGender");
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.User", b =>
                {
                    b.Property<string>("user_name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("pass_word")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("user_name");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            user_name = "admin",
                            Role = 0,
                            pass_word = "admin"
                        },
                        new
                        {
                            user_name = "ceaser.krit",
                            Role = 0,
                            pass_word = "admin123"
                        },
                        new
                        {
                            user_name = "nazim.amin",
                            Role = 0,
                            pass_word = "admin"
                        },
                        new
                        {
                            user_name = "kitchen",
                            Role = 1,
                            pass_word = "kitchen"
                        },
                        new
                        {
                            user_name = "_kitchen",
                            Role = 1,
                            pass_word = "kitchen_"
                        });
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.Reserver", b =>
                {
                    b.HasOne("HotelManagment_Day11.Models.ReserverChoices", "choices")
                        .WithMany("Reservers")
                        .HasForeignKey("choices_id");

                    b.HasOne("HotelManagment_Day11.Models.ResrverGender", "gender")
                        .WithMany("Reservers")
                        .HasForeignKey("gender_id");

                    b.HasOne("HotelManagment_Day11.Models.ReserverState", "state")
                        .WithMany("Reservers")
                        .HasForeignKey("state_id");

                    b.Navigation("choices");

                    b.Navigation("gender");

                    b.Navigation("state");
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.ReserverChoices", b =>
                {
                    b.Navigation("Reservers");
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.ReserverState", b =>
                {
                    b.Navigation("Reservers");
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.ResrverGender", b =>
                {
                    b.Navigation("Reservers");
                });
#pragma warning restore 612, 618
        }
    }
}

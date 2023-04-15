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
    [Migration("20230409180542_UpdateFooDMenueTable")]
    partial class UpdateFooDMenueTable
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

                    b.Property<int>("room_number")
                        .HasColumnType("int");

                    b.Property<string>("room_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("send_sms")
                        .HasColumnType("bit");

                    b.Property<bool>("supply_status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("resrver_id");

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

                    b.ToTable("ReserverStates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            State = "Alabama"
                        },
                        new
                        {
                            Id = 2,
                            State = "Alaska"
                        },
                        new
                        {
                            Id = 3,
                            State = "Arizona"
                        },
                        new
                        {
                            Id = 4,
                            State = "Arkansas"
                        },
                        new
                        {
                            Id = 5,
                            State = "California"
                        },
                        new
                        {
                            Id = 6,
                            State = "Colorado"
                        },
                        new
                        {
                            Id = 7,
                            State = "Connecticut"
                        },
                        new
                        {
                            Id = 8,
                            State = "Delaware"
                        },
                        new
                        {
                            Id = 9,
                            State = "District Of Columbia"
                        },
                        new
                        {
                            Id = 10,
                            State = "Florida"
                        },
                        new
                        {
                            Id = 11,
                            State = "Georgia"
                        },
                        new
                        {
                            Id = 12,
                            State = "Hawaii"
                        },
                        new
                        {
                            Id = 13,
                            State = "Idaho"
                        },
                        new
                        {
                            Id = 14,
                            State = "Illinois"
                        },
                        new
                        {
                            Id = 15,
                            State = "Indiana"
                        },
                        new
                        {
                            Id = 16,
                            State = "Iowa"
                        },
                        new
                        {
                            Id = 17,
                            State = "Kansas"
                        },
                        new
                        {
                            Id = 18,
                            State = "Kentucky"
                        },
                        new
                        {
                            Id = 19,
                            State = "Louisiana"
                        },
                        new
                        {
                            Id = 20,
                            State = "Maine"
                        },
                        new
                        {
                            Id = 21,
                            State = "Maryland"
                        },
                        new
                        {
                            Id = 22,
                            State = "Massachusetts"
                        },
                        new
                        {
                            Id = 23,
                            State = "Michigan"
                        },
                        new
                        {
                            Id = 24,
                            State = "Minnesota"
                        },
                        new
                        {
                            Id = 25,
                            State = "Mississippi"
                        },
                        new
                        {
                            Id = 26,
                            State = "Missouri"
                        },
                        new
                        {
                            Id = 27,
                            State = "Montana"
                        },
                        new
                        {
                            Id = 28,
                            State = "Nebraska"
                        },
                        new
                        {
                            Id = 29,
                            State = "New Hampshire"
                        },
                        new
                        {
                            Id = 30,
                            State = "New Jersey"
                        },
                        new
                        {
                            Id = 31,
                            State = "New Mexico"
                        },
                        new
                        {
                            Id = 32,
                            State = "New York"
                        });
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.Reserver_Service", b =>
                {
                    b.Property<int>("ReserverID")
                        .HasColumnType("int");

                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ReserverID", "ServiceID");

                    b.ToTable("Reservers_Services");
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

                    b.ToTable("ResrverGenders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Gender = "Male"
                        },
                        new
                        {
                            Id = 2,
                            Gender = "Female"
                        },
                        new
                        {
                            Id = 3,
                            Gender = "Others"
                        });
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("service")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            price = 7,
                            service = "break_fast"
                        },
                        new
                        {
                            Id = 2,
                            price = 15,
                            service = "lunch"
                        },
                        new
                        {
                            Id = 3,
                            price = 15,
                            service = "dinner"
                        },
                        new
                        {
                            Id = 4,
                            price = 20,
                            service = "cleaning"
                        },
                        new
                        {
                            Id = 5,
                            price = 14,
                            service = "towel"
                        },
                        new
                        {
                            Id = 6,
                            price = 30,
                            service = "Sweetest Surprise"
                        });
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

            modelBuilder.Entity("ReserverReserver_Service", b =>
                {
                    b.Property<int>("ReserversId")
                        .HasColumnType("int");

                    b.Property<int>("servicesReserverID")
                        .HasColumnType("int");

                    b.Property<int>("servicesServiceID")
                        .HasColumnType("int");

                    b.HasKey("ReserversId", "servicesReserverID", "servicesServiceID");

                    b.HasIndex("servicesReserverID", "servicesServiceID");

                    b.ToTable("ReserverReserver_Service");
                });

            modelBuilder.Entity("Reserver_ServiceService", b =>
                {
                    b.Property<int>("ServicesId")
                        .HasColumnType("int");

                    b.Property<int>("Reserver_ServiceReserverID")
                        .HasColumnType("int");

                    b.Property<int>("Reserver_ServiceServiceID")
                        .HasColumnType("int");

                    b.HasKey("ServicesId", "Reserver_ServiceReserverID", "Reserver_ServiceServiceID");

                    b.HasIndex("Reserver_ServiceReserverID", "Reserver_ServiceServiceID");

                    b.ToTable("Reserver_ServiceService");
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.Reserver", b =>
                {
                    b.HasOne("HotelManagment_Day11.Models.ResrverGender", "gender")
                        .WithMany("Reservers")
                        .HasForeignKey("gender_id");

                    b.HasOne("HotelManagment_Day11.Models.ReserverState", "state")
                        .WithMany("Reservers")
                        .HasForeignKey("state_id");

                    b.Navigation("gender");

                    b.Navigation("state");
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.ReserverChoices", b =>
                {
                    b.HasOne("HotelManagment_Day11.Models.Reserver", "Reserver")
                        .WithMany("choices")
                        .HasForeignKey("resrver_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserver");
                });

            modelBuilder.Entity("ReserverReserver_Service", b =>
                {
                    b.HasOne("HotelManagment_Day11.Models.Reserver", null)
                        .WithMany()
                        .HasForeignKey("ReserversId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagment_Day11.Models.Reserver_Service", null)
                        .WithMany()
                        .HasForeignKey("servicesReserverID", "servicesServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Reserver_ServiceService", b =>
                {
                    b.HasOne("HotelManagment_Day11.Models.Service", null)
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagment_Day11.Models.Reserver_Service", null)
                        .WithMany()
                        .HasForeignKey("Reserver_ServiceReserverID", "Reserver_ServiceServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelManagment_Day11.Models.Reserver", b =>
                {
                    b.Navigation("choices");
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

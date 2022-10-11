﻿// <auto-generated />
using System;
using AgendaApi.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendaApi.Migrations
{
    [DbContext(typeof(AgendaApiContext))]
    [Migration("20221004224649_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("AgendaApi.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CelularNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("TelephoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserdID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CelularNumber = 341457896L,
                            Description = "Plomero",
                            Name = "Jaimito",
                            UserId = 1,
                            UserdID = 0
                        },
                        new
                        {
                            Id = 2,
                            CelularNumber = 34156978L,
                            Description = "Papa",
                            Name = "Pepe",
                            TelephoneNumber = 422568L,
                            UserId = 2,
                            UserdID = 0
                        },
                        new
                        {
                            Id = 3,
                            CelularNumber = 11425789L,
                            Description = "Jefa",
                            Name = "Maria",
                            UserId = 1,
                            UserdID = 0
                        });
                });

            modelBuilder.Entity("AgendaApi.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "karenbailapiola@gmail.com",
                            LastName = "Lasot",
                            Name = "Karen",
                            Password = "Pa$$w0rd",
                            UserName = "karenpiola"
                        },
                        new
                        {
                            Id = 2,
                            Email = "elluismidetotoras@gmail.com",
                            LastName = "Gonzales",
                            Name = "Luis Gonzalez",
                            Password = "lamismadesiempre",
                            UserName = "luismitoto"
                        });
                });

            modelBuilder.Entity("AgendaApi.Entities.Contact", b =>
                {
                    b.HasOne("AgendaApi.Entities.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AgendaApi.Entities.User", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using APICinemaProject.DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APICinemaProject.DAL.Migrations
{
    [DbContext(typeof(AbContext))]
    [Migration("20220519063707_MM")]
    partial class MM
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APICinemaProject.DAL.Models.CandyShop", b =>
                {
                    b.Property<int>("CandyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CandyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CandyPrice")
                        .HasColumnType("int");

                    b.Property<string>("CandyType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandyID");

                    b.ToTable("candyShops");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CustomerGender")
                        .HasColumnType("bit");

                    b.Property<bool>("CustomerIsVIP")
                        .HasColumnType("bit");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("genres");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.Hall", b =>
                {
                    b.Property<int>("HallID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountOfSeats")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("HallID");

                    b.ToTable("halls");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.LoyaltyProgram", b =>
                {
                    b.Property<int>("LoyaltyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("LoyaltyID");

                    b.ToTable("loyaltyPrograms");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.Merchandise", b =>
                {
                    b.Property<int>("MerchandiseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MerchandiseColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchandiseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MerchandisePrice")
                        .HasColumnType("int");

                    b.Property<string>("MerchandiseSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchandiseType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MerchandiseID");

                    b.ToTable("merchandises");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.MovieGenre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("movieGenres");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AgeCheck")
                        .HasColumnType("bit");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.Seat", b =>
                {
                    b.Property<int>("SeatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HallID")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("SeatRowLetter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeatID");

                    b.ToTable("seats");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GenreID")
                        .HasColumnType("int");

                    b.Property<int>("MovieAgeLimit")
                        .HasColumnType("int");

                    b.Property<int>("MoviePlayTime")
                        .HasColumnType("int");

                    b.HasKey("MovieID");

                    b.HasIndex("GenreID");

                    b.ToTable("movies");
                });

            modelBuilder.Entity("CandyShopOrder", b =>
                {
                    b.Property<int>("CandyShopsCandyID")
                        .HasColumnType("int");

                    b.Property<int>("OrdersOrderID")
                        .HasColumnType("int");

                    b.HasKey("CandyShopsCandyID", "OrdersOrderID");

                    b.HasIndex("OrdersOrderID");

                    b.ToTable("CandyShopOrder");
                });

            modelBuilder.Entity("OrderSeat", b =>
                {
                    b.Property<int>("OrdersOrderID")
                        .HasColumnType("int");

                    b.Property<int>("SeatsSeatID")
                        .HasColumnType("int");

                    b.HasKey("OrdersOrderID", "SeatsSeatID");

                    b.HasIndex("SeatsSeatID");

                    b.ToTable("OrderSeat");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Movie", b =>
                {
                    b.HasOne("APICinemaProject.DAL.Models.Genre", null)
                        .WithMany("Movies")
                        .HasForeignKey("GenreID");
                });

            modelBuilder.Entity("CandyShopOrder", b =>
                {
                    b.HasOne("APICinemaProject.DAL.Models.CandyShop", null)
                        .WithMany()
                        .HasForeignKey("CandyShopsCandyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APICinemaProject.DAL.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderSeat", b =>
                {
                    b.HasOne("APICinemaProject.DAL.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APICinemaProject.DAL.Models.Seat", null)
                        .WithMany()
                        .HasForeignKey("SeatsSeatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}

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
    [Migration("20220520062437_20_05_03")]
    partial class _20_05_03
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APICinemaProject.DAL.Database.Models.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorID");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.CandyShop", b =>
                {
                    b.Property<int>("CandyShopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CandyShopName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CandyShopPrice")
                        .HasColumnType("int");

                    b.Property<string>("CandyShopType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandyShopID");

                    b.ToTable("CandyShops");
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

                    b.ToTable("Customers");
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

                    b.ToTable("Genres");
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

                    b.ToTable("Halls");
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

                    b.HasIndex("CustomerID");

                    b.HasIndex("OrderID");

                    b.ToTable("LoyaltyPrograms");
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

                    b.ToTable("Merchandises");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GenreID")
                        .HasColumnType("int");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<int>("MovieAgeLimit")
                        .HasColumnType("int");

                    b.Property<int>("MoviePlayTime")
                        .HasColumnType("int");

                    b.HasKey("MovieID");

                    b.HasIndex("GenreID");

                    b.ToTable("Movies");
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

                    b.ToTable("MovieGenres");
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

                    b.ToTable("Orders");
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

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("ActorsActorID")
                        .HasColumnType("int");

                    b.Property<int>("MoviesMovieID")
                        .HasColumnType("int");

                    b.HasKey("ActorsActorID", "MoviesMovieID");

                    b.HasIndex("MoviesMovieID");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("CandyShopOrder", b =>
                {
                    b.Property<int>("CandyShopsCandyShopID")
                        .HasColumnType("int");

                    b.Property<int>("OrdersOrderID")
                        .HasColumnType("int");

                    b.HasKey("CandyShopsCandyShopID", "OrdersOrderID");

                    b.HasIndex("OrdersOrderID");

                    b.ToTable("CandyShopOrder");
                });

            modelBuilder.Entity("MovieMovieGenre", b =>
                {
                    b.Property<int>("MovieGenresGenreID")
                        .HasColumnType("int");

                    b.Property<int>("MoviesMovieID")
                        .HasColumnType("int");

                    b.HasKey("MovieGenresGenreID", "MoviesMovieID");

                    b.HasIndex("MoviesMovieID");

                    b.ToTable("MovieMovieGenre");
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

            modelBuilder.Entity("APICinemaProject.DAL.Models.LoyaltyProgram", b =>
                {
                    b.HasOne("APICinemaProject.DAL.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APICinemaProject.DAL.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("APICinemaProject.DAL.Models.Movie", b =>
                {
                    b.HasOne("APICinemaProject.DAL.Models.Genre", null)
                        .WithMany("Movies")
                        .HasForeignKey("GenreID");
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("APICinemaProject.DAL.Database.Models.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APICinemaProject.DAL.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesMovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyShopOrder", b =>
                {
                    b.HasOne("APICinemaProject.DAL.Models.CandyShop", null)
                        .WithMany()
                        .HasForeignKey("CandyShopsCandyShopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APICinemaProject.DAL.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieMovieGenre", b =>
                {
                    b.HasOne("APICinemaProject.DAL.Models.MovieGenre", null)
                        .WithMany()
                        .HasForeignKey("MovieGenresGenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APICinemaProject.DAL.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesMovieID")
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
